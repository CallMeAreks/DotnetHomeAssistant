using DotnetHomeAssistant.Apps.LightOnMovement.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.LightOnMovement;

[NetDaemonApp]
public class UpstairsHallwayMotionActivatedLightsApp : MotionActivatedLightsApp
{
    public UpstairsHallwayMotionActivatedLightsApp(IHaContext ha) : base(ha, AutomaticLightsParametersFactory())
    {
    }

    private static Func<Entities,AutomaticLightsParameters> AutomaticLightsParametersFactory()
    {
        return entities => new AutomaticLightsParameters(
            entities.BinarySensor.LumiLumiSensorMotionAq225c1ec07IasZone,
            new[] { entities.Light.UpstairsHallwayLights },
            AutomaticLightBehavior.FixedDuration);
    }
}