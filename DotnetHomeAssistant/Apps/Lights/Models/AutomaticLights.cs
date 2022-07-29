using System.Collections.Generic;
using System.Linq;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights.Models;

public class AutomaticLights
{
    private static readonly TimeSpan DefaultDuration = TimeSpan.FromMinutes(5);
    private readonly IEnumerable<LightEntity> _dayDayLights;
    private readonly IEnumerable<LightEntity> _nightLights;

    public AutomaticLights(Entity trigger,
        IEnumerable<LightEntity> dayLights,
        IEnumerable<LightEntity>? nightLights = null,
        AutomaticLightBehavior behavior = AutomaticLightBehavior.WhileTriggerIsOn,
        TimeSpan? duration = null)
    {
        Trigger = trigger;
        _dayDayLights = dayLights;
        _nightLights = nightLights ?? Enumerable.Empty<LightEntity>();
        Behavior = behavior;
        Duration = duration ?? DefaultDuration;
    }

    public Entity Trigger { get; }
    public AutomaticLightBehavior Behavior { get; }
    public TimeSpan Duration { get; }

    public void TurnOn()
    {
        if (DateTime.Now.Hour is > 1 and < 7)
        {
            _nightLights.TurnOn(brightnessPct: 30);
        }
        else
        {
            _dayDayLights.TurnOn();
        }
    }

    public void TurnOff() => _dayDayLights.Concat(_nightLights).TurnOff();
}