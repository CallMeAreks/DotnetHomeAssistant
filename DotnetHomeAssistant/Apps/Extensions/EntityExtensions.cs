using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Extensions;

public static class EntityExtensions
{
    /// <summary>Checks if en EntityState has the state "armed_away"</summary>
    /// <param name="entityState">The state to check</param>
    /// <returns>true if the state equals "armed_away", otherwise false</returns>
    public static bool IsArmedAway(this EntityState? entityState) => string.Equals(entityState?.State, Alarm.ArmedAway, StringComparison.OrdinalIgnoreCase);

    /// <summary>Checks if en EntityState has the state "disarmed"</summary>
    /// <param name="entityState">The state to check</param>
    /// <returns>true if the state equals "disarmed", otherwise false</returns>
    public static bool IsDisarmed(this EntityState? entityState) => string.Equals(entityState?.State, Alarm.Disarmed, StringComparison.OrdinalIgnoreCase);
}