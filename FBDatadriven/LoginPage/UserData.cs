/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace FBDatadriven.LoginPage
{
    public class UserData
    {
        public string Email;
        public string Password;

        public UserData(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
