using EshopManager.Client.Infrastructure.Extensions;
using EshopManager.Shared.Wrapper;
using System.Net.Http;
using System.Threading.Tasks;
using EshopManager.Application.Features.Dashboards.Queries.GetData;

namespace EshopManager.Client.Infrastructure.Managers.Dashboard
{
    public class DashboardManager : IDashboardManager
    {
        private readonly HttpClient _httpClient;

        public DashboardManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<DashboardDataResponse>> GetDataAsync()
        {
            var response = await _httpClient.GetAsync(Routes.DashboardEndpoints.GetData);
            var data = await response.ToResult<DashboardDataResponse>();
            return data;
        }
    }
}