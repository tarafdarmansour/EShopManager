using EshopManager.Shared.Wrapper;
using System.Threading.Tasks;
using EshopManager.Application.Features.Dashboards.Queries.GetData;

namespace EshopManager.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}