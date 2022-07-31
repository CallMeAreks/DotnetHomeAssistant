using DotnetHomeAssistant.Apps.Lights.Models;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.EntitySync;

[NetDaemonApp]
public class LivingRoomPersonDetection
{
    public LivingRoomPersonDetection(Entities entities)
    {
        // Turn on camera person detection only when the PIR detected motion to reduce CPU usage
        entities.BinarySensor.LivingRoomPresenceSensor
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(_ => entities.Switch.LivingRoomDetect.TurnOn());

        entities.BinarySensor.LivingRoomPresenceSensor
            .StateChanges()
            .Where(e => e.New.IsOff())
            .Subscribe(_ => entities.Switch.LivingRoomDetect.TurnOff());
    }
}