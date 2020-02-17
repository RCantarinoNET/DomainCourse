using System;

namespace Course.Domain.Entities.Base
{
    public abstract class AuditableEntity
    {
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}