using System;

namespace Course.Domain.Entities.Base
{
    public abstract class EntityBase : Base.AuditableEntity
    {
        public EntityBase()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
    }
}