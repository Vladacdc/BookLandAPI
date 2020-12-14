using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        //DbSets
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}