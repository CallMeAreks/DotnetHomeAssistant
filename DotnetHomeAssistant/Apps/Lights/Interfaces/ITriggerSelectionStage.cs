using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.Lights.Interfaces;

public interface ITriggerSelectionStage
{
    public IBehaviorSelectionStage TriggeredBy(BinarySensorEntity trigger, params BinarySensorEntity[] triggers);
}