using EshopManager.Application.Interfaces.Services;
using System;

namespace EshopManager.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}