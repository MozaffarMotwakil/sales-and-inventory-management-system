using System;
using System.IO;
using BusinessLogic.Users;

namespace BusinessLogic
{
    public enum enMode
    { 
        Add, 
        Update
    };

    public class clsAppSettings
    {
        public static clsUser CurrentUser = new clsUser(1);

        public static string AppDataFolder
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData); }
        }

        public static string PeopleImagesFolderPath
        {
            get
            {
                string peopleImagesFolderPath = Path.Combine(AppDataFolder, "ALWAHA-People-Images");

                if (!Directory.Exists(peopleImagesFolderPath))
                {
                    Directory.CreateDirectory(peopleImagesFolderPath);
                }

                return peopleImagesFolderPath;
            }
        }

        public static string GetNewImagePathWithGUID()
        {
            return Path.Combine(PeopleImagesFolderPath, $"{Guid.NewGuid()}.JPG");
        }
    }
}
