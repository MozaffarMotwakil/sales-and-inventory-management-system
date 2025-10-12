using System;
using System.IO;
using BusinessLogic.Users;

namespace BusinessLogic
{
    public enum enMode
    { 
        Add = 1, 
        Update
    };

    public class clsAppSettings
    {
        public static clsUser CurrentUser = new clsUser(1);

        public const string ErrorToConnectionFormDB = "عذرا,حدثت مشكلة أثناء الإتصال مع قاعدة البيانات, الرجاء المحاولة لاحقا.";

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

        public static string ProductImagesFolderPath
        {
            get
            {
                string peopleImagesFolderPath = Path.Combine(AppDataFolder, "ALWAHA-Product-Images");

                if (!Directory.Exists(peopleImagesFolderPath))
                {
                    Directory.CreateDirectory(peopleImagesFolderPath);
                }

                return peopleImagesFolderPath;
            }
        }

        public static string GetNewImagePathWithGUIDForPeople()
        {
            return Path.Combine(PeopleImagesFolderPath, $"{Guid.NewGuid()}.JPG");
        }

        public static string GetNewImagePathWithGUIDForProduct()
        {
            return Path.Combine(ProductImagesFolderPath, $"{Guid.NewGuid()}.JPG");
        }

    }
}
