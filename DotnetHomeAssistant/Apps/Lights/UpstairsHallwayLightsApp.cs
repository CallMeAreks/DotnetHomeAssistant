using DotnetHomeAssistant.Apps.Lights.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.Lights;

[NetDaemonApp]
public class UpstairsHallwayLightsApp : MotionActivatedLightsApp
{
    public UpstairsHallwayLightsApp(IHaContext ha) : base(ha, AutomaticLightsFactory())
    {
    }

    private static Func<Entities, AutomaticLights> AutomaticLightsFactory()
    {
        return entities => new  AutomaticLights(
            trigger: entities.BinarySensor.LumiLumiSensorMotionAq225c1ec07IasZone,
            dayLights: new [] { entities.Light.UpstairsHallwayLights },
            nightLights: new [] { entities.Light.YeelightColor0x0000000007eca741 },
            behavior: AutomaticLightBehavior.FixedDuration );
    }
}