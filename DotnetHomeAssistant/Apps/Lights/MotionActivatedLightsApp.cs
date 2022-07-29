using DotnetHomeAssistant.Apps.Extensions;
using DotnetHomeAssistant.Apps.Lights.Models;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights;

public abstract class MotionActivatedLightsApp
{
    protected AutomaticLights AutomaticLights { get; }
    protected Entities Entities { get; }

    protected MotionActivatedLightsApp(IHaContext ha, Func<Entities, AutomaticLights> factory)
    {
        Entities = new Entities(ha);
        AutomaticLights = factory(Entities);

        AutomaticLights.Trigger
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(TurnOnLights);

        AutomaticLights.Trigger
            .StateChanges()
            .WhenTriggerIsOffFor(AutomaticLights)
            .Subscribe(TurnOffLights);
    }

    protected virtual void TurnOnLights(StateChange _)
    {
        if (Entities.Sun.BelowNightlyElevationThreshold())
        {
            AutomaticLights.TurnOn();
        }
    }

    protected virtual void TurnOffLights(StateChange _)
    {
        AutomaticLights.TurnOff();
    }
}