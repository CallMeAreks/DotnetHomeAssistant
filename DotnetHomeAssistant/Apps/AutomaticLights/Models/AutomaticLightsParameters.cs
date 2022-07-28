using System.Collections.Generic;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.AutomaticLights.Models;

public record AutomaticLightsParameters(
    Entity Trigger,
    IEnumerable<LightEntity> Lights,
    AutomaticLightBehavior Behavior = AutomaticLightBehavior.WhileTriggerIsOn,
    int DurationInMinutes = 5);