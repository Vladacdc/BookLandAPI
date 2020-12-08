using System.Threading.Tasks;
using Core.Common;

namespace Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}