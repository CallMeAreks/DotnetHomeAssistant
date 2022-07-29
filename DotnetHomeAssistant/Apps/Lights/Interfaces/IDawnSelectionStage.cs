using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights.Interfaces;

public interface IDawnSelectionStage
{
    public ITriggerSelectionStage AndDawnLights(params LightEntity[] lightEntities);
    public IBehaviorSelectionStage TriggeredBy(Entity trigger);
}

public interface ITriggerSelectionStage
{
    public IBehaviorSelectionStage TriggeredBy(Entity trigger);
}