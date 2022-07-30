using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.Lights.Interfaces;

public interface IConditionSelectionStage
{
    public IInitializeStage AndRoomIsDark(NumericSensorEntity lightSensor);
    IAutomaticLights Initialize();
}