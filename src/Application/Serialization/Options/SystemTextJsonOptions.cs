using System.Text.Json;
using EshopManager.Application.Interfaces.Serialization.Options;

namespace EshopManager.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}