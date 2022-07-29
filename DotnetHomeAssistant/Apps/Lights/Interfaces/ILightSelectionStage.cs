using HomeAssistantGenerated;

namespace DotnetHomeAssistant.Apps.Lights.Interfaces;

public interface ILightSelectionStage
{
    public IDawnSelectionStage HandleLights(LightEntity lightEntity, params LightEntity[] lightEntities);
}