using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using RomoTimer.Model;

namespace RomoTimerForm.Controller
{
    internal class AdminLoggedController
    {
        public List<User> GetAllUsers()
        {
            using (RomoTimerDBEntities romo = new RomoTimerDBEntities())
            {
                return romo.Users.ToList();
            }
        }

        public void InsertUser(User user)
        {
            using (RomoTimerDBEntities romo = new RomoTimerDBEntities())
            {
                romo.Users.Add(user);
                romo.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (RomoTimerDBEntities romo = new RomoTimerDBEntities())
            {
                var userDelete = romo.Users.Where(u => u.Id == id).FirstOrDefault();
                if (userDelete != null)
                {
                    romo.Users.Remove(userDelete);
                    romo.SaveChanges();
                }
            }
        }
        public void Edit(User user)
        {
            using (RomoTimerDBEntities romo = new RomoTimerDBEntities())
            {
                romo.Users.AddOrUpdate(user);
                romo.SaveChanges();
            }
        }
    }
}
