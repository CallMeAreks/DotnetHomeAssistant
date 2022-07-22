using System.Collections.Generic;
using System.Linq;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.LightOnMovement;

public abstract class MotionActivatedLightsApp
{
    private readonly Entities _entities;
    private readonly Services _services;

    private readonly List<string> _eveningLights = new();
    private readonly List<string> _nightLights = new();

    protected MotionActivatedLightsApp(IHaContext ha, string motionSensorId, bool turnOffAutomatically = true)
    {
        _entities = new Entities(ha);
        _services = new Services(ha);

        ha.Entity(motionSensorId)
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(TurnOnLights);

        if (turnOffAutomatically)
        {
            ha.Entity(motionSensorId)
                .StateChanges()
                .WhenStateIsFor(e => e.IsOff(), TimeSpan.FromMinutes(5))
                .Subscribe(TurnOffLights);
        }
    }

    protected void SetEveningLights(params string[] entityIds) => _eveningLights.AddRange(entityIds);
    protected void SetNightLights(params string[] entityIds) => _nightLights.AddRange(entityIds);

    protected virtual void TurnOnLights(StateChange stateChange)
    {
        if (_eveningLights.Any() && _entities.Sun.Sun.State == "below_horizon")
        {
            _services.Light.TurnOn(ServiceTarget.FromEntities(_eveningLights));
        }
    }

    protected virtual void TurnOffLights(StateChange stateChange)
    {
        _services.Light.TurnOff(ServiceTarget.FromEntities(_eveningLights.Concat(_nightLights)));
    }
}