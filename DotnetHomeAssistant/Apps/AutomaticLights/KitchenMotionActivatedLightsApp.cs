﻿using DotnetHomeAssistant.Apps.AutomaticLights.Models;
using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.AutomaticLights;

[NetDaemonApp]
public class KitchenMotionActivatedLightsApp : MotionActivatedLightsApp
{
    public KitchenMotionActivatedLightsApp(IHaContext ha) : base(ha, AutomaticLightsParametersFactory())
    {
    }

    private static Func<Entities,AutomaticLightsParameters> AutomaticLightsParametersFactory()
    {
        return entities => new AutomaticLightsParameters(
            Trigger: entities.BinarySensor.KitchenPresenceSensor,
            Lights: new [] { entities.Light.KitchenLights1, entities.Light.KitchenLights2 } );
    }
}