namespace DotnetHomeAssistant.Apps;

public static class Constants
{
    public static class CameraRecordingMode
    {
        public const string Never = "Never";
        public const string Always = "Always";
        public const string Detections = "Detections";
    }

    public static class Alarm
    {
        public const string ArmedAway = "armed_away";
        public const string ArmedHome = "armed_home";
        public const string Disarmed = "disarmed";
        public const string Triggered = "triggered";
    }

    public static class Sun
    {
        public const int ElevationThresholdAtNight = 8;
    }
}