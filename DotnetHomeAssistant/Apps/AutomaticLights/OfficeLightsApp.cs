using DotnetHomeAssistant.Apps.AutomaticLights.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.AutomaticLights;

[NetDaemonApp]
public class OfficeLightsApp : MotionActivatedLightsApp
{
    public OfficeLightsApp(IHaContext ha) : base(ha, AutomaticLightsParametersFactory())
    {
    }

    private static Func<Entities,AutomaticLightsParameters> AutomaticLightsParametersFactory()
    {
        return entities => new AutomaticLightsParameters(
            Trigger: entities.BinarySensor.OfficeMotion,
            Behavior: AutomaticLightBehavior.FixedDuration,
            Lights: new [] { entities.Light.UpstairsRoomLights } );
    }
}