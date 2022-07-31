using DotnetHomeAssistant.Apps.Lights.Models;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights;

[NetDaemonApp]
public class KitchenLightsApp
{
    public KitchenLightsApp(Entities entities)
    {
        AutomaticLights.ConfigureWith(entities)
            .HandleLights(entities.Light.KitchenLights1, entities.Light.KitchenLights2)
            .AndDawnLights(entities.Light.KitchenFanLights)
            .TriggeredBy(entities.BinarySensor.KitchenPresenceSensor)
            .WhileOn()
            .Initialize();

        entities.BinarySensor.KitchenPresenceSensor
            .StateChanges()
            .WhenStateIsFor(e => e.IsOff(), TimeSpan.FromMinutes(5))
            .Subscribe(_ => entities.Fan.KitchenFan.TurnOff());
    }
}