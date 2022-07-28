using DotnetHomeAssistant.Apps.LightOnMovement.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.LightOnMovement;

[NetDaemonApp]
public class OfficeMotionActivatedLightsApp : MotionActivatedLightsApp
{
    public OfficeMotionActivatedLightsApp(IHaContext ha) : base(ha, AutomaticLightsFactory())
    {
    }

    private static Func<Entities,AutomaticLights> AutomaticLightsFactory()
    {
        return entities => new AutomaticLights(
            entities.BinarySensor.OfficeMotion,
            new[] { entities.Light.UpstairsRoomLights },
            AutomaticLightBehavior.FixedDuration);
    }
}