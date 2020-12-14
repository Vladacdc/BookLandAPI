using System;

namespace Core.Common
{
    public abstract class DomainEvent
    {
        protected DomainEvent()
        {
            DateOccured = DateTimeOffset.UtcNow;
        }

        public bool IsPublished { get; set; }
        
        public DateTimeOffset DateOccured { get; protected set; }
    }
}