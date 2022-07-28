using DotnetHomeAssistant.Apps.LightOnMovement.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.LightOnMovement;

[NetDaemonApp]
public class KitchenMotionActivatedLightsApp : MotionActivatedLightsApp
{
    public KitchenMotionActivatedLightsApp(IHaContext ha) : base(ha, AutomaticLightsParametersFactory())
    {
    }

    private static Func<Entities,AutomaticLightsParameters> AutomaticLightsParametersFactory()
    {
        return entities => new AutomaticLightsParameters(
            entities.BinarySensor.KitchenPresenceSensor,
            new [] { entities.Light.KitchenLights1, entities.Light.KitchenLights2 });
    }
}