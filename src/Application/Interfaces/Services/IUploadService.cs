using EshopManager.Application.Requests;

namespace EshopManager.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}