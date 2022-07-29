using DotnetHomeAssistant.Apps.Extensions;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.AlarmSystem;

[NetDaemonApp]
public sealed class AlarmSystemStateApp
{
    private readonly Entities _entities;

    public AlarmSystemStateApp(Entities entities)
    {
        _entities = entities;

        _entities.BinarySensor.Home
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Subscribe(_ => _entities.AlarmControlPanel.Alarm.AlarmDisarm());

        _entities.BinarySensor.Home
            .StateChanges()
            .Where(e => e.New.IsOff())
            .Subscribe(_ => _entities.AlarmControlPanel.Alarm.AlarmArmAway());

        _entities.AlarmControlPanel.Alarm
            .StateChanges()
            .Where(e => e.New.IsArmedAway())
            .Subscribe(TurnOnMotionRecording);

        _entities.AlarmControlPanel.Alarm
            .StateChanges()
            .Where(e => e.New.IsDisarmed())
            .Subscribe(TurnOffMotionRecording);
    }

    private void TurnOnMotionRecording(StateChange _)
    {
        _entities.Switch.CameraMotionDetections.TurnOn();
        SetCamerasRecordingModes(CameraRecordingMode.Detections);
    }

    private void TurnOffMotionRecording(StateChange _)
    {
        SetCamerasRecordingModes(CameraRecordingMode.Never);
    }

    private void SetCamerasRecordingModes(string mode)
    {
        _entities.Select.G3FlexRecordingMode2.SelectOption(mode); // Garage
        _entities.Select.G3FlexRecordingMode3.SelectOption(mode); // Patio
        _entities.Select.LivingRoomRecordingMode.SelectOption(mode);
        _entities.Select.DownstairsRoomRecordingMode.SelectOption(mode);
        _entities.Select.BedroomRecordingMode.SelectOption(mode);
        _entities.Select.OfficeRecordingMode.SelectOption(mode);
    }
}