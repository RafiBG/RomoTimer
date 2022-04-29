using MaterialSkin;
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
        
        public static void SavedSettings()
        {
            MaterialSkinManager TManager = MaterialSkinManager.Instance;

            SettingsController settingsController = new SettingsController();
            bool isDarkTheme = settingsController.IsDarkTheme();
            if (isDarkTheme)
            {
                //Check if is dark theme is true set it on dark
                isDarkTheme = true;
                TManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                //Chekc if is dark theme is false set it on light
                isDarkTheme = false;
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
            //Check if is blue scheme is true set it on blue
            bool isBlueScheme = settingsController.IsBlueScheme();
            if (isBlueScheme)
            {
                isBlueScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            }
            //Check if is red scheme is true set it on red
            bool isRedScheme = settingsController.IsRedScheme();
            if (isRedScheme)
            {
                isRedScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Red800,
                Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            }
            //Check if is green scheme is true set it on green
            bool isGreenScheme = settingsController.IsGreenScheme();
            if (isGreenScheme)
            {
                isGreenScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Green800,
                Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
            }
            //Check if is orange scheme is true set it on orange
            bool isOrangeScheme = settingsController.IsOrangeScheme();
            if (isOrangeScheme)
            {
                isOrangeScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Orange800,
                Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
            }
        }
    }
}
