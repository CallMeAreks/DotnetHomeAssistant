namespace DotnetHomeAssistant.Apps.LightOnMovement;

[NetDaemonApp]
public class UpstairsHallwayMotionActivatedLightsApp : MotionActivatedLightsApp
{
    public UpstairsHallwayMotionActivatedLightsApp(IHaContext ha)
        : base(ha, "binary_sensor.lumi_lumi_sensor_motion_aq2_25c1ec07_ias_zone")
    {
        SetEveningLights("light.upstairs_hallway_lights");
    }
}