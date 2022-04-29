using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomoTimer.Model;

namespace RomoTimerForm.Controller
{
    class LoginController
    {
        public bool IsUserLogged(string username, string password)
        {
            using (RomoTimerDBEntities romo = new RomoTimerDBEntities())
            {
                bool isLogged = false;
                foreach (var user in romo.Users)
                {
                    if (user.Username == username && user.Password == password)
                    {
                        isLogged = true;
                        CurrentUserInfo.Id = user.Id;
                        
                    }
                }
                return isLogged;
            }
        }

        public bool IsAdmin(string username, string password)
        {
            bool isAdmin = false;
            {
                if (username == "admin" && password == "adminpass")
                {
                    isAdmin = true;
                    CurrentUserInfo.Id = 0;
                }
            }
            return isAdmin;
        }
    }
}
