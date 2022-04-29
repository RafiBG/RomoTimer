using RomoTimer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace RomoTimer.Controller
{
    internal class RomoTasksController
    {
        public List<RomoTask> GetAllUsers()
        {
            using (RomoTimerDBEntities romo = new RomoTimerDBEntities())
            {
                return romo.RomoTasks.ToList();
            }
        }

        public void InsertUser(RomoTask romoTask)
        {
            using (RomoTimerDBEntities romo = new RomoTimerDBEntities())
            {
                romo.RomoTasks.Add(romoTask);
                romo.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (RomoTimerDBEntities romo = new RomoTimerDBEntities())
            {
                var taskDelete = romo.RomoTasks.Where(u => u.Id == id).FirstOrDefault();
                if (taskDelete != null)
                {
                    romo.RomoTasks.Remove(taskDelete);
                    romo.SaveChanges();
                }
            }
        }
        public void Edit(RomoTask romoTask)
        {
            using (RomoTimerDBEntities romo = new RomoTimerDBEntities())
            {
                romo.RomoTasks.AddOrUpdate(romoTask);
                romo.SaveChanges();
            }
        }
    }
}
