﻿using System.Collections.Generic;
using System.Linq;
using DotnetHomeAssistant.Apps.Extensions;
using DotnetHomeAssistant.Apps.Lights.Interfaces;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights.Models;

public class AutomaticLights : IAutomaticLights, ILightSelectionStage, IDawnSelectionStage, ITriggerSelectionStage, IBehaviorSelectionStage, IInitializeStage
{
    private static readonly TimeSpan DefaultDuration = TimeSpan.FromMinutes(5);
    private readonly Entities _entities;

    private readonly List<LightEntity> _lights = new();
    private readonly List<LightEntity> _dawnLights = new();

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

    public IAutomaticLights Initialize()
    {
        _trigger
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(_ => TurnOn());

        _trigger
            .StateChanges()
            .WhenTriggerIsOffFor(_behavior, _duration)
            .Subscribe(_ => TurnOff());

        return this;
    }

    public void TurnOn()
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

    public void TurnOff() => _lights.Concat(_dawnLights).TurnOff();

    public IDawnSelectionStage HandleLights(LightEntity lightEntity, params LightEntity[] lightEntities)
    {
        _lights.Add(lightEntity);
        _lights.AddRange(lightEntities);
        return this;
    }

    public ITriggerSelectionStage AndDawnLights(LightEntity lightEntity, params LightEntity[] lightEntities)
    {
        _dawnLights.Add(lightEntity);
        _dawnLights.AddRange(lightEntities);
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