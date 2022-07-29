using DotnetHomeAssistant.Apps.Lights.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.Lights;

[NetDaemonApp]
public class OfficeLightsApp : MotionActivatedLightsApp
{
    public OfficeLightsApp(IHaContext ha) : base(ha, AutomaticLightsFactory())
    {
    }

    private static Func<Entities, AutomaticLights> AutomaticLightsFactory()
    {
        return entities => new AutomaticLights(
            trigger: entities.BinarySensor.OfficeMotion,
            dayLights: new [] { entities.Light.UpstairsRoomLights },
            behavior: AutomaticLightBehavior.FixedDuration);
    }
}