using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights.Interfaces;

public interface IDawnSelectionStage
{
    public ITriggerSelectionStage AndDawnLights(LightEntity lightEntity, params LightEntity[] lightEntities);
    public IBehaviorSelectionStage TriggeredBy(Entity trigger);
}