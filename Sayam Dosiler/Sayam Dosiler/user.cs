using System;
using System.Collections.Generic;
using System.Text;

namespace Sayam_Dosiler
{
    class User : Worker
    {
        private string _username;
        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length<=15)
                {
                    this._username = value;
                }
            }
        }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length >= 8)
                {
                    this._password = value;
                }
            }
        }


        public User(string username, string password, string name, string surname, string email) :base(name,surname,email)
        {
            this.UserName = username;
            this.Password = password;
        }
    }
}
