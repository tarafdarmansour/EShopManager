using EshopManager.Application.Interfaces.Common;
using EshopManager.Application.Requests.Identity;
using EshopManager.Shared.Wrapper;
using System.Threading.Tasks;

namespace EshopManager.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}