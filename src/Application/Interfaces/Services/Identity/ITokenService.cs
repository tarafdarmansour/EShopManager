using EshopManager.Application.Interfaces.Common;
using EshopManager.Application.Requests.Identity;
using EshopManager.Application.Responses.Identity;
using EshopManager.Shared.Wrapper;
using System.Threading.Tasks;

namespace EshopManager.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}