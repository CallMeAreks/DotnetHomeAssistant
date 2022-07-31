using DotnetHomeAssistant.Apps.Lights.Models;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights;

[NetDaemonApp]
public class LivingRoomLightsApp
{
    public LivingRoomLightsApp(Entities entities)
    {
        var automaticLights = AutomaticLights.ConfigureWith(entities)
            .HandleLights(entities.Light.LivingRoomLights1, entities.Light.LivingRoomLights2, entities.Light.LivingRoomLights3)
            .AndDawnLights(entities.Light.LivingRoomFanLights)
            .TriggeredBy(entities.BinarySensor.LivingRoomPresenceSensor)
            .WithDefaultDuration()
            .Initialize();

        entities.BinarySensor.LumiLumiSensorMagnetAq2OnOff
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(_ => automaticLights.TurnOn());

        entities.BinarySensor.LivingRoomPresenceSensor
            .StateChanges()
            .WhenStateIsFor(e => e.IsOff(), TimeSpan.FromMinutes(5))
            .Subscribe(_ => entities.Fan.LivingRoomFans.TurnOff());
    }
}