using System.Collections.Generic;
using System.Linq;
using DotnetHomeAssistant.Apps.Extensions;
using DotnetHomeAssistant.Apps.Lights.Interfaces;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights.Models;

public class AutomaticLights : ILightSelectionStage, IDawnSelectionStage, IBehaviorSelectionStage, IInitializeStage
{
    private static readonly TimeSpan DefaultDuration = TimeSpan.FromMinutes(5);
    private readonly Entities _entities;

    private List<LightEntity> _lights = null!;
    private List<LightEntity> _dawnLights = null!;

    private Entity _trigger = null!;
    private AutomaticLightBehavior _behavior;
    private TimeSpan _duration;

    private AutomaticLights(Entities entities)
    {
        _entities = entities;
    }

    public static ILightSelectionStage ConfigureWith(Entities entities)
    {
        return new AutomaticLights(entities);
    }

    public AutomaticLights Initialize()
    {
        _trigger
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(TurnOn);

        _trigger
            .StateChanges()
            .WhenTriggerIsOffFor(_behavior, _duration)
            .Subscribe(TurnOff);

        return this;
    }

    public void TurnOn(StateChange _)
    {
        if (!_entities.Sun.BelowNightlyElevationThreshold())
        {
            return;
        }

        if (DateTime.Now.Hour is > 1 and < 7 && _dawnLights.Any())
        {
            _dawnLights.TurnOn(brightnessPct: 30);
        }
        else
        {
            _lights.TurnOn();
        }
    }

    public void TurnOff(StateChange _) => _lights.Concat(_dawnLights).TurnOff();

    public IDawnSelectionStage HandleLights(params LightEntity[] lightEntities)
    {
        _lights = lightEntities.ToList();
        return this;
    }

    public IDawnSelectionStage AndDawnLights(params LightEntity[] lightEntities)
    {
        _dawnLights = lightEntities.ToList();
        return this;
    }

    public IBehaviorSelectionStage TriggeredBy(Entity trigger)
    {
        _trigger = trigger;
        return this;
    }

    public IInitializeStage WhileOn()
    {
        _behavior = AutomaticLightBehavior.WhileTriggerIsOn;
        return this;
    }

    public IInitializeStage WithDefaultDuration()
    {
        _behavior = AutomaticLightBehavior.FixedDuration;
        _duration = DefaultDuration;
        return this;
    }

    public IInitializeStage WithDuration(TimeSpan duration)
    {
        _behavior = AutomaticLightBehavior.FixedDuration;
        _duration = duration;
        return this;
    }
}