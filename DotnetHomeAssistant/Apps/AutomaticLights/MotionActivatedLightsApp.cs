using DotnetHomeAssistant.Apps.AutomaticLights.Models;
using DotnetHomeAssistant.Apps.Extensions;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.AutomaticLights;

public abstract class MotionActivatedLightsApp
{
    private readonly AutomaticLightsParameters _parameters;
    private readonly Entities _entities;

    protected MotionActivatedLightsApp(IHaContext ha, Func<Entities,AutomaticLightsParameters> parametersFactory)
    {
        _entities = new Entities(ha);
        _parameters = parametersFactory(_entities);

        _parameters.Trigger
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(TurnOnLights);

        _parameters.Trigger
            .StateChanges()
            .WhenTriggerIsOffFor(_parameters)
            .Subscribe(TurnOffLights);
    }

    protected virtual void TurnOnLights(StateChange _)
    {
        if (_entities.Sun.Sun.Attributes!.Elevation < Sun.ElevationThresholdAtNight)
        {
            _parameters.Lights.TurnOn();
        }
    }

    protected virtual void TurnOffLights(StateChange _)
    {
        _parameters.Lights.TurnOff();
    }
}