﻿using OwinSample.Models;

namespace OwinSample.Service
{
    public class UserService
    {
        public User GetUserByCredentials(string email, string password)
        {
            if (email != "email@domain.com" || password != "password")
            {
                return null;
            }
            User user = new User() { Id = "1", Email = "email@domain.com", Password = "password", Name = "Mike McDonald" };
            if (user != null)
            {
                user.Password = string.Empty;
            }
            return user;
        }
    }
}