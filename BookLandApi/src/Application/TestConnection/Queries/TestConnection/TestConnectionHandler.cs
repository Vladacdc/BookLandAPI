using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Application.TestConnection.Queries.TestConnection
{
    public class TestConnectionHandler : IRequestHandler<TestConnection, bool>
    {
        public async Task<bool> Handle(TestConnection request, CancellationToken cancellationToken)
        {
            return true;
        }
    }
}