using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.Lights.Interfaces;

public interface IDawnSelectionStage
{
    public ITriggerSelectionStage AndDawnLights(LightEntity lightEntity, params LightEntity[] lightEntities);
    public IBehaviorSelectionStage TriggeredBy(BinarySensorEntity trigger, params BinarySensorEntity[] triggers);
}