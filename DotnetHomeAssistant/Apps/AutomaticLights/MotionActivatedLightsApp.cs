using DotnetHomeAssistant.Apps.AutomaticLights.Models;
using DotnetHomeAssistant.Apps.Extensions;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.AutomaticLights;

public abstract class MotionActivatedLightsApp
{
    protected readonly AutomaticLightsParameters Parameters;
    protected readonly Entities Entities;

    protected MotionActivatedLightsApp(IHaContext ha, Func<Entities,AutomaticLightsParameters> parametersFactory)
    {
        Entities = new Entities(ha);
        Parameters = parametersFactory(Entities);

        Parameters.Trigger
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(TurnOnLights);

        Parameters.Trigger
            .StateChanges()
            .WhenTriggerIsOffFor(Parameters)
            .Subscribe(TurnOffLights);
    }

    protected virtual void TurnOnLights(StateChange _)
    {
        if (Entities.Sun.BelowNightlyElevationThreshold())
        {
            Parameters.Lights.TurnOn();
        }
    }

    protected virtual void TurnOffLights(StateChange _)
    {
        Parameters.Lights.TurnOff();
    }
}