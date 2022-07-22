using NetDaemon.HassModel.Entities;

namespace HomeAssistantGenerated;

public record HumidifierEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
{
    public HumidifierEntity(Entity entity) : base(entity)
    {
    }

    public HumidifierEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
    {
    }
}