using DotnetHomeAssistant.Apps.Extensions;
using DotnetHomeAssistant.Apps.LightOnMovement.Models;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;
using static DotnetHomeAssistant.Apps.Constants;

namespace DotnetHomeAssistant.Apps.LightOnMovement;

public abstract class MotionActivatedLightsApp
{
    private readonly AutomaticLights _automaticLights;
    private readonly Entities _entities;

    protected MotionActivatedLightsApp(IHaContext ha, Func<Entities,AutomaticLights> automaticLightsFactory)
    {
        _entities = new Entities(ha);
        _automaticLights = automaticLightsFactory(_entities);

        _automaticLights.TriggerEntity
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(TurnOnLights);

        _automaticLights.TriggerEntity
            .StateChanges()
            .WhenTriggerIsOffFor(_automaticLights)
            .Subscribe(TurnOffLights);
    }

    protected virtual void TurnOnLights(StateChange stateChange)
    {
        if (_entities.Sun.Sun.Attributes!.Elevation < SunElevationThresholdAtNight)
        {
            _automaticLights.Lights.TurnOn();
        }
    }

    protected virtual void TurnOffLights(StateChange stateChange)
    {
        _automaticLights.Lights.TurnOff();
    }
}