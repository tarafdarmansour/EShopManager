using EshopManager.Shared.Settings;
using System.Threading.Tasks;
using EshopManager.Shared.Wrapper;

namespace EshopManager.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}