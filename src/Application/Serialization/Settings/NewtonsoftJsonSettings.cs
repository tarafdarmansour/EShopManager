
using EshopManager.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace EshopManager.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}