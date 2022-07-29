using DotnetHomeAssistant.Apps.Lights.Models;

namespace DotnetHomeAssistant.Apps.Lights.Interfaces;

public interface IInitializeStage
{
    AutomaticLights Initialize();
}