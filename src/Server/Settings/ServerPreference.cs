using System.Linq;
using EshopManager.Shared.Constants.Localization;
using EshopManager.Shared.Settings;

namespace EshopManager.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}