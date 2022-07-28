using DotnetHomeAssistant.Apps.LightOnMovement.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.LightOnMovement;

[NetDaemonApp]
public class UpstairsHallwayMotionActivatedLightsApp : MotionActivatedLightsApp
{
    public UpstairsHallwayMotionActivatedLightsApp(IHaContext ha) : base(ha, AutomaticLightsFactory())
    {
    }

    private static Func<Entities,AutomaticLights> AutomaticLightsFactory()
    {
        return entities => new AutomaticLights(
            entities.BinarySensor.LumiLumiSensorMotionAq225c1ec07IasZone,
            new[] { entities.Light.UpstairsHallwayLights },
            AutomaticLightBehavior.FixedDuration);
    }
}