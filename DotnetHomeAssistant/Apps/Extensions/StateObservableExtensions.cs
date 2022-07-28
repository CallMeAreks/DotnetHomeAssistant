using DotnetHomeAssistant.Apps.LightOnMovement.Models;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Extensions;

public static class StateObservableExtensions
{
    public static IObservable<StateChange> WhenTriggerIsOffFor(this IObservable<StateChange> stateChange, AutomaticLights automaticLights)
    {
        if (automaticLights.LightBehavior == AutomaticLightBehavior.WhileTriggerIsOn)
        {
            return stateChange.Where(e => e.New.IsOff());
        }

        return stateChange.WhenStateIsFor(e => e.IsOff(), TimeSpan.FromMinutes(automaticLights.DurationInMinutes));
    }
}