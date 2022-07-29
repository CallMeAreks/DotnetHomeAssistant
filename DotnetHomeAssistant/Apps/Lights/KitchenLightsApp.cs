using DotnetHomeAssistant.Apps.Lights.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.Lights;

[NetDaemonApp]
public class KitchenLightsApp
{
    public KitchenLightsApp(Entities entities)
    {
        AutomaticLights.ConfigureWith(entities)
            .HandleLights(entities.Light.KitchenLights1, entities.Light.KitchenLights2)
            .AndDawnLights(entities.Light.KitchenLights1, entities.Light.KitchenLights2)
            .TriggeredBy(entities.BinarySensor.KitchenPresenceSensor)
            .WhileOn()
            .Initialize();
    }
}