using System;
using System.Collections.Generic;
using System.Text;

namespace Login
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { protected get; set; }
        public string Username { get; set; }

        public User()
        {

        }
        public User(string firstName, string lastName, string password, string username)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Username = username;
        }
        public string CheckPassword()
        {
            return Password;
        }
        public string UpdatePassword(string newPassword)
        {
            return Password = newPassword;
        }
    }
}

