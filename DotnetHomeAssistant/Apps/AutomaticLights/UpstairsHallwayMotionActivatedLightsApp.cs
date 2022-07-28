using DotnetHomeAssistant.Apps.AutomaticLights.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.AutomaticLights;

[NetDaemonApp]
public class UpstairsHallwayMotionActivatedLightsApp : MotionActivatedLightsApp
{
    public UpstairsHallwayMotionActivatedLightsApp(IHaContext ha) : base(ha, AutomaticLightsParametersFactory())
    {
    }

    private static Func<Entities,AutomaticLightsParameters> AutomaticLightsParametersFactory()
    {
        return entities => new AutomaticLightsParameters(
            Trigger: entities.BinarySensor.LumiLumiSensorMotionAq225c1ec07IasZone,
            Behavior: AutomaticLightBehavior.FixedDuration,
            Lights: new [] { entities.Light.UpstairsHallwayLights } );
    }
}