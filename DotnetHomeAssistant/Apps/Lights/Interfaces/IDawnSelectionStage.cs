using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights.Interfaces;

public interface IDawnSelectionStage
{
    public IDawnSelectionStage AndDawnLights(params LightEntity[] lightEntities);
    public IBehaviorSelectionStage TriggeredBy(Entity trigger);
}