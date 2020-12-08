using System;

namespace Core.Common
{
    public abstract class AuditableEntity
    {
        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }
        
        public DateTime? Updated { get; set; }
        
        public string UpdatedBy { get; set; }
    }
}