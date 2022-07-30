using DotnetHomeAssistant.Apps.Lights.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.Lights;

[NetDaemonApp]
public class UpstairsHallwayLightsApp
{
    public UpstairsHallwayLightsApp(Entities entities)
    {
        AutomaticLights.ConfigureWith(entities)
            .HandleLights(entities.Light.UpstairsHallwayLights)
            .AndDawnLights(entities.Light.YeelightColor0x0000000007eca741)
            .TriggeredBy(entities.BinarySensor.LumiLumiSensorMotionAq225c1ec07IasZone)
            .WithDefaultDuration()
            .AndRoomIsDark(entities.Sensor.LumiLumiSensorMotionAq225c1ec07Illuminance)
            .Initialize();
    }
}