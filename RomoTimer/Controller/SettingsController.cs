using RomoTimer.Model;
using System.Linq;


namespace RomoTimerForm.Controller
{
    public class SettingsController
    {
        public bool IsDarkTheme()
        {
            using (RomoTimerDBEntities r = new RomoTimerDBEntities())
            {
                return r.Settings.ToList().FirstOrDefault().IsDarkTheme;
            }
        }
        public void SetTheme(bool isDarkTheme)
        {
            using (RomoTimerDBEntities r = new RomoTimerDBEntities())
            {
                var setting = r.Settings.FirstOrDefault();
                setting.IsDarkTheme = isDarkTheme;
                r.SaveChanges();
            }
        }
        public bool IsBlueScheme()
        {
            using (RomoTimerDBEntities r = new RomoTimerDBEntities())
            {
                return (bool)r.Settings.ToList().FirstOrDefault().IsBlueScheme;
            }
        }
        public bool IsRedScheme()
        {
            using (RomoTimerDBEntities r = new RomoTimerDBEntities())
            {
                return (bool)r.Settings.ToList().FirstOrDefault().IsRedScheme;
            }
        }
        public bool IsGreenScheme()
        {
            using (RomoTimerDBEntities r = new RomoTimerDBEntities())
            {
                return (bool)r.Settings.ToList().FirstOrDefault().IsGreenScheme;
            }
        }
        public bool IsOrangeScheme()
        {
            using (RomoTimerDBEntities r = new RomoTimerDBEntities())
            {
                return (bool)r.Settings.ToList().FirstOrDefault().IsOrangeScheme;
            }
        }
        public void SetBlueScheme(bool isBlueScheme)
        {
            using (RomoTimerDBEntities r = new RomoTimerDBEntities())
            {
                var setting = r.Settings.FirstOrDefault();
                setting.IsBlueScheme = isBlueScheme;
                r.SaveChanges();
            }
        }
        public void SetRedScheme(bool isRedScheme)
        {
            using (RomoTimerDBEntities r = new RomoTimerDBEntities())
            {
                var setting = r.Settings.FirstOrDefault();
                setting.IsRedScheme = isRedScheme;
                r.SaveChanges();
            }
        }
        public void SetGreenScheme(bool isGreenScheme)
        {
            using (RomoTimerDBEntities r = new RomoTimerDBEntities())
            {
                var setting = r.Settings.FirstOrDefault();
                setting.IsGreenScheme = isGreenScheme;
                r.SaveChanges();
            }
        }
        public void SetOrangeScheme(bool isOrangeScheme)
        {
            using (RomoTimerDBEntities r = new RomoTimerDBEntities())
            {
                var setting = r.Settings.FirstOrDefault();
                setting.IsOrangeScheme = isOrangeScheme;
                r.SaveChanges();
            }
        }
    }
}
