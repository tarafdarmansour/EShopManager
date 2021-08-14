﻿using System.ComponentModel.DataAnnotations;

namespace EshopManager.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}