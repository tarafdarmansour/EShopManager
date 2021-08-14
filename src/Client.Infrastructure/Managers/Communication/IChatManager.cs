using EshopManager.Application.Models.Chat;
using EshopManager.Application.Responses.Identity;
using EshopManager.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using EshopManager.Application.Interfaces.Chat;

namespace EshopManager.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}