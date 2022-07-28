using System.Collections.Generic;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.LightOnMovement.Models;

public record AutomaticLightsParameters(
    Entity TriggerEntity,
    IReadOnlyCollection<LightEntity> Lights,
    AutomaticLightBehavior LightBehavior = AutomaticLightBehavior.WhileTriggerIsOn,
    int DurationInMinutes = 5);