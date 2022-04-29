using System;
using System.Collections.Generic;
using System.Linq;
using RomoTimer.Model;

namespace RomoTimerForm.Controller
{
    public class RegisterController
    {
        public void InsertUser(User user)
        {
            using (RomoTimerDBEntities romo = new RomoTimerDBEntities())
            {
                romo.Users.Add(user);
                romo.SaveChanges();
            }
        }

        public bool IsUserRegistered(string username)
        {
            using (RomoTimerDBEntities romo = new RomoTimerDBEntities())
            {
                bool isRegistered = romo.Users
                    .Where(item => item.Username == username)
                    .Any();

                return isRegistered;
            }
        }
        public bool IsNotEmpty(string username, string first_name, string last_name, string password)
        {
            bool isNotEmpty = false;
            if (username == null || first_name == null || last_name == null || password == null)
            {
                isNotEmpty = true;
            }
            return isNotEmpty;
        }
    }
}
