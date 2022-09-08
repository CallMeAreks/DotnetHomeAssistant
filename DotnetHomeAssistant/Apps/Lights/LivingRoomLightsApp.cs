using DotnetHomeAssistant.Apps.Lights.Models;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights;

[NetDaemonApp]
public class LivingRoomLightsApp
{
    public LivingRoomLightsApp(Entities entities)
    {
        AutomaticLights.ConfigureWith(entities)
            .HandleLights(entities.Light.LivingRoomCeilingLights)
            .AndDawnLights(entities.Light.LivingRoomFanLights)
            .TriggeredBy(entities.BinarySensor.LivingRoomPresenceSensor)
            .WhileOn()
            .Register();

        entities.BinarySensor.LivingRoomPresenceSensor
            .StateChanges()
            .WhenStateIsFor(e => e.IsOff(), TimeSpan.FromMinutes(30))
            .Subscribe(_ => entities.Fan.LivingRoomFans.TurnOff());
    }
}