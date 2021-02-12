using System;
using System.Collections.Generic;
using System.Text;

namespace Sayam_Dosiler
{
    interface HRManager
    {
       public List<User> Users { get;}
        public void AddUser(User user);
        public void EditUser(string UserName, string newUserName);
        public void DeleteUser(string UserName);
        public List<User> ShowUsers();
        public User ShowInfoByName(string name);
       
    }
}
