namespace DotnetHomeAssistant.Apps.LightOnMovement;

[NetDaemonApp]
public class KitchenMotionActivatedLightsApp : MotionActivatedLightsApp
{
    public KitchenMotionActivatedLightsApp(IHaContext ha)
        : base(ha, "binary_sensor.lumi_lumi_sensor_motion_aq2_ias_zone")
    {
        SetEveningLights("light.kitchen_lights_1", "light.kitchen_lights_2");
    }
}