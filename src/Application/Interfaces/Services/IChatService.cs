﻿using EshopManager.Application.Responses.Identity;
using EshopManager.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using EshopManager.Application.Interfaces.Chat;
using EshopManager.Application.Models.Chat;

namespace EshopManager.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}