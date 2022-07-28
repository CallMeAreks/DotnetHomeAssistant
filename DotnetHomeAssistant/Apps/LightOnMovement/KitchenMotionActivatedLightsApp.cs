using DotnetHomeAssistant.Apps.LightOnMovement.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.LightOnMovement;

[NetDaemonApp]
public class KitchenMotionActivatedLightsApp : MotionActivatedLightsApp
{
    public KitchenMotionActivatedLightsApp(IHaContext ha) : base(ha, AutomaticLightsFactory())
    {
    }

    private static Func<Entities,AutomaticLights> AutomaticLightsFactory()
    {
        return entities => new AutomaticLights(
            entities.BinarySensor.KitchenPresenceSensor,
            new [] { entities.Light.KitchenLights1, entities.Light.KitchenLights2 });
    }
}