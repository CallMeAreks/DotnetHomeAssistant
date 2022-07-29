using DotnetHomeAssistant.Apps.Lights.Models;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Extensions;

public static class StateObservableExtensions
{
    public static IObservable<StateChange> WhenTriggerIsOffFor(this IObservable<StateChange> stateChange,
        AutomaticLightBehavior lightBehavior, TimeSpan duration)
    {
        if (lightBehavior == AutomaticLightBehavior.WhileTriggerIsOn)
        {
            return stateChange.Where(e => e.New.IsOff());
        }

        return stateChange.WhenStateIsFor(e => e.IsOff(), duration);
    }
}