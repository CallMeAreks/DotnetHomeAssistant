namespace DotnetHomeAssistant.Apps.LightOnMovement;

[NetDaemonApp]
public class OfficeMotionActivatedLightsApp : MotionActivatedLightsApp
{
    public OfficeMotionActivatedLightsApp(IHaContext ha)
        : base(ha, "binary_sensor.office_motion", turnOffAutomatically: false)
    {
        SetEveningLights("light.upstairs_room_lights");
    }
}