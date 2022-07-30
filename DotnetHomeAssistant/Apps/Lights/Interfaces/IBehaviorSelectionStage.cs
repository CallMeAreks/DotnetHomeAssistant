namespace DotnetHomeAssistant.Apps.Lights.Interfaces;

public interface IBehaviorSelectionStage
{
    public IConditionSelectionStage WhileOn();
    public IConditionSelectionStage WithDefaultDuration();
    public IConditionSelectionStage WithDuration(TimeSpan duration);
}