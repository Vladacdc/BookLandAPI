using Application.Common.Security;
using MediatR;

namespace Application.TestConnection.Queries.TestConnection
{
    [Authorize]
    public class TestConnection : IRequest<bool>
    {
    }
}