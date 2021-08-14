using AutoMapper;
using EshopManager.Application.Interfaces.Chat;
using EshopManager.Application.Models.Chat;
using EshopManager.Infrastructure.Models.Identity;

namespace EshopManager.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}