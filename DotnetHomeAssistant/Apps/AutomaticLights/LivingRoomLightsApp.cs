using DotnetHomeAssistant.Apps.AutomaticLights.Models;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.AutomaticLights;

[NetDaemonApp]
public class LivingRoomLightsApp : MotionActivatedLightsApp
{
    public LivingRoomLightsApp(IHaContext ha) : base(ha, AutomaticLightsParametersFactory())
    {
        Entities.BinarySensor.LumiLumiSensorMagnetAq2OnOff
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(TurnOnLights);
    }

    private static Func<Entities, AutomaticLightsParameters> AutomaticLightsParametersFactory()
    {
        return entities => new AutomaticLightsParameters(
            Trigger: entities.BinarySensor.LivingRoomPresenceSensor,
            Behavior: AutomaticLightBehavior.FixedDuration,
            Lights: new [] { entities.Light.LivingRoomLights1, entities.Light.LivingRoomLights2, entities.Light.LivingRoomLights3 });
    }
}