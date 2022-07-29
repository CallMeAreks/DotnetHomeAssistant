namespace DotnetHomeAssistant.Apps.Lights.Interfaces;

public interface IBehaviorSelectionStage
{
    public IInitializeStage WhileOn();
    public IInitializeStage WithDefaultDuration();
    public IInitializeStage WithDuration(TimeSpan duration);
}