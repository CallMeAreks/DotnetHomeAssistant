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
            .HandleLights(entities.Light.LivingRoomLights1, entities.Light.LivingRoomLights2, entities.Light.LivingRoomLights3)
            .AndDawnLights(entities.Light.LivingRoomFanLights)
            .TriggeredBy(entities.BinarySensor.LivingRoomPresenceSensor, entities.BinarySensor.LumiLumiSensorMagnetAq2OnOff, entities.BinarySensor.LumiLumiSensorMagnetAq2E370e007OnOff)
            .WithDuration(TimeSpan.FromMinutes(30))
            .Register();

        entities.BinarySensor.LivingRoomPresenceSensor
            .StateChanges()
            .WhenStateIsFor(e => e.IsOff(), TimeSpan.FromMinutes(30))
            .Subscribe(_ => entities.Fan.LivingRoomFans.TurnOff());
    }
}