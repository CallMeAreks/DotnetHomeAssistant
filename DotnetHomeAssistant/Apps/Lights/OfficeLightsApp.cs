using DotnetHomeAssistant.Apps.Lights.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.Lights;

[NetDaemonApp]
public class OfficeLightsApp
{
    public OfficeLightsApp(Entities entities)
    {
        AutomaticLights.ConfigureWith(entities)
            .HandleLights(entities.Light.UpstairsRoomLights)
            .TriggeredBy(entities.BinarySensor.OfficeMotion)
            .WithDefaultDuration()
            .Register();
    }
}