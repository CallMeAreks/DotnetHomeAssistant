using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Lights.Interfaces;

public interface ITriggerSelectionStage
{
    public IBehaviorSelectionStage TriggeredBy(Entity trigger);
}