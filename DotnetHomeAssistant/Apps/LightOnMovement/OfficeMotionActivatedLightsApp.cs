using DotnetHomeAssistant.Apps.LightOnMovement.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.LightOnMovement;

[NetDaemonApp]
public class OfficeMotionActivatedLightsApp : MotionActivatedLightsApp
{
    public OfficeMotionActivatedLightsApp(IHaContext ha) : base(ha, AutomaticLightsParametersFactory())
    {
    }

    private static Func<Entities,AutomaticLightsParameters> AutomaticLightsParametersFactory()
    {
        return entities => new AutomaticLightsParameters(
            entities.BinarySensor.OfficeMotion,
            new[] { entities.Light.UpstairsRoomLights },
            AutomaticLightBehavior.FixedDuration);
    }
}