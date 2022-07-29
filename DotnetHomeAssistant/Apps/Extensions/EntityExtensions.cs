using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace DotnetHomeAssistant.Apps.Extensions;

public static class EntityExtensions
{
    /// <summary>Checks if an EntityState has the state "armed_away"</summary>
    /// <param name="entityState">The state to check</param>
    /// <returns>true if the state equals "armed_away", otherwise false</returns>
    public static bool IsArmedAway(this EntityState? entityState) => string.Equals(entityState?.State, Alarm.ArmedAway, StringComparison.OrdinalIgnoreCase);

    /// <summary>Checks if an EntityState has the state "disarmed"</summary>
    /// <param name="entityState">The state to check</param>
    /// <returns>true if the state equals "disarmed", otherwise false</returns>
    public static bool IsDisarmed(this EntityState? entityState) => string.Equals(entityState?.State, Alarm.Disarmed, StringComparison.OrdinalIgnoreCase);

    /// <summary>Checks if the sun elevation is below the threshold defined in constants.</summary>
    /// <param name="sunEntities">The sun entities group to check</param>
    /// <returns>true if the elevation attribute is below "ElevationThresholdAtNight", otherwise false</returns>
    public static bool BelowNightlyElevationThreshold(this SunEntities sunEntities)
    {
        return sunEntities.Sun.Attributes!.Elevation < Sun.ElevationThresholdAtNight;
    }
}