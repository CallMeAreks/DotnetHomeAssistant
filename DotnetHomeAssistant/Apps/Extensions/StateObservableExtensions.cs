using DotnetHomeAssistant.Apps.LightOnMovement.Models;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Extensions;

public static class StateObservableExtensions
{
    public static IObservable<StateChange> WhenTriggerIsOffFor(this IObservable<StateChange> stateChange, AutomaticLightsParameters parameters)
    {
        if (parameters.LightBehavior == AutomaticLightBehavior.WhileTriggerIsOn)
        {
            return stateChange.Where(e => e.New.IsOff());
        }

        return stateChange.WhenStateIsFor(e => e.IsOff(), TimeSpan.FromMinutes(parameters.DurationInMinutes));
    }
}