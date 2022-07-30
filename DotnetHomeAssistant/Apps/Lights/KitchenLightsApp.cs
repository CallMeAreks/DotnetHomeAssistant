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
            .AndDawnLights(entities.Light.KitchenFanLights)
            .TriggeredBy(entities.BinarySensor.KitchenPresenceSensor)
            .WhileOn()
            .AndRoomIsDark(entities.Sensor.LumiLumiSensorMotionAq2Illuminance)
            .Initialize();
    }
}