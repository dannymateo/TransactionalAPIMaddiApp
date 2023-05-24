﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TransactionalAPIMaddiApp.Models
{
    public class ChangePasswordByOTPViewModel
    {
        public Guid User_Id { get; set; }
        public string Password { get; set; }
        public string OTP { get; set; }
    }
}
