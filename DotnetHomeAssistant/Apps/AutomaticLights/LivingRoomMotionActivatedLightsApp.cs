using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.AutomaticLights;

[NetDaemonApp]
public class LivingRoomMotionActivatedLightsApp
{
    private readonly Entities _entities;

    public LivingRoomMotionActivatedLightsApp(IHaContext ha)
    {
        _entities = new Entities(ha);

        _entities.BinarySensor.LumiLumiSensorMagnetAq2OnOff
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(TurnOnLights);

        _entities.BinarySensor.LivingRoomMotion
            .StateChanges()
            .WhenStateIsFor( e => e.IsOff(), TimeSpan.FromMinutes(5))
            .Subscribe(TurnOffLights);
    }

    private void TurnOnLights(StateChange stateChange)
    {
        _entities.Light.LivingRoomLights1.TurnOn();
        _entities.Light.LivingRoomLights2.TurnOn();
        _entities.Light.LivingRoomLights3.TurnOn();
    }

    private void TurnOffLights(StateChange stateChange)
    {
        _entities.Light.LivingRoomLights1.TurnOff();
        _entities.Light.LivingRoomLights2.TurnOff();
        _entities.Light.LivingRoomLights3.TurnOff();
    }
}