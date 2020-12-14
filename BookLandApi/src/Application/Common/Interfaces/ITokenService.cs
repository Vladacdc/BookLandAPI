using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface ITokenService
    {
        Task<string> GenerateTokenAsync(string username);
    }
}