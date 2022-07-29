using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.Lights;

[NetDaemonApp]
public class KitchenLightsApp : MotionActivatedLightsApp
{
    public KitchenLightsApp(IHaContext ha) : base(ha, AutomaticLightsFactory())
    {
    }

    private static Func<Entities,Models.AutomaticLights> AutomaticLightsFactory()
    {
        return entities => new Models.AutomaticLights(
            trigger: entities.BinarySensor.KitchenPresenceSensor,
            dayLights: new [] { entities.Light.KitchenLights1, entities.Light.KitchenLights2 },
            nightLights: new [] { entities.Light.KitchenFanLights });
    }
}