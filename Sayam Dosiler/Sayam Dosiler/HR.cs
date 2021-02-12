using System;
using System.Collections.Generic;
using System.Text;

namespace Sayam_Dosiler
{
    class HR : HRManager
    {
        public List<User> Users { get { return this.users; } }
        private List<User> users;
        public HR()
        {
            this.users = new List<User>();
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string UserName)
        {
            throw new NotImplementedException();
        }

        public void EditUser(string UserName, string newUserName)
        {
            throw new NotImplementedException();
        }

        public User ShowInfoByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<User> ShowUsers()
        {
            throw new NotImplementedException();
        }
    }
}
