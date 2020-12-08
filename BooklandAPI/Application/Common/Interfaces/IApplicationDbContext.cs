using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        //DbSets
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}