using DotnetHomeAssistant.Apps.Extensions;
using DotnetHomeAssistant.Apps.LightOnMovement.Models;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;
using static DotnetHomeAssistant.Apps.Constants;

namespace DotnetHomeAssistant.Apps.LightOnMovement;

public abstract class MotionActivatedLightsApp
{
    private readonly AutomaticLightsParameters _parameters;
    private readonly Entities _entities;

    protected MotionActivatedLightsApp(IHaContext ha, Func<Entities,AutomaticLightsParameters> automaticLightsFactory)
    {
        _entities = new Entities(ha);
        _parameters = automaticLightsFactory(_entities);

        _parameters.TriggerEntity
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(TurnOnLights);

        _parameters.TriggerEntity
            .StateChanges()
            .WhenTriggerIsOffFor(_parameters)
            .Subscribe(TurnOffLights);
    }

    protected virtual void TurnOnLights(StateChange stateChange)
    {
        if (_entities.Sun.Sun.Attributes!.Elevation < SunElevationThresholdAtNight)
        {
            _parameters.Lights.TurnOn();
        }
    }

    protected virtual void TurnOffLights(StateChange stateChange)
    {
        _parameters.Lights.TurnOff();
    }
}