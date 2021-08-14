using EshopManager.Application.Interfaces.Common;

namespace EshopManager.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}