﻿using BussinessObject.Models;
namespace ShopProjectAccountAPI.Helper
{
    public class TokenReponse
    {
        public Account Account { get; set; }
        public string AccessToken { get; set; }
    }
}
