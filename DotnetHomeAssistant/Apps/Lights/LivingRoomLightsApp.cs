using DotnetHomeAssistant.Apps.Lights.Models;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights;

[NetDaemonApp]
public class LivingRoomLightsApp : MotionActivatedLightsApp
{
    public LivingRoomLightsApp(IHaContext ha) : base(ha, AutomaticLightsFactory())
    {
        Entities.BinarySensor.LumiLumiSensorMagnetAq2OnOff
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(TurnOnLights);
    }

    private static Func<Entities, AutomaticLights> AutomaticLightsFactory()
    {
        return entities => new AutomaticLights(
            trigger: entities.BinarySensor.LivingRoomPresenceSensor,
            dayLights: new [] { entities.Light.LivingRoomLights1, entities.Light.LivingRoomLights2, entities.Light.LivingRoomLights3 },
            nightLights: new [] { entities.Light.LivingRoomFanLights },
            behavior: AutomaticLightBehavior.FixedDuration);
    }
}