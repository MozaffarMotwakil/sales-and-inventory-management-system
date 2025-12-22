
using System;
using Microsoft.Win32;

namespace DVLD.WinForms.Utils
{
    public static class clsLoginManager
    {
        private const string _BasekeyPath = @"HKEY_CURRENT_USER\Software\DVLD";
        private const string _SubkeyPath = @"Software\DVLD";
        private const string _UsernameValueName = "Username";
        private const string _PasswordValueName = "Password";

        public static void SaveLoginInformation(string Username, string Password)
        {
            if (IsLoginInformationExist())
            {
                UpdatedLoginInformation(Username, Password);
                return;
            }

            try
            {
                Registry.SetValue(_BasekeyPath, _UsernameValueName, Username, RegistryValueKind.String);
                Registry.SetValue(_BasekeyPath, _PasswordValueName, Password, RegistryValueKind.String);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to save a login information: {ex.Message}.");
            }
        }
        public static void UpdatedLoginInformation(string Username, string Password)
        {
            if (IsLoginInformationExist())
            {
                try
                {
                    Registry.SetValue(_BasekeyPath, _UsernameValueName, Username, RegistryValueKind.String);
                    Registry.SetValue(_BasekeyPath, _PasswordValueName, Password, RegistryValueKind.String);
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        public static void DeleteLoginInformation()
        {
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(_SubkeyPath, true))
                    {
                        if (key != null)
                        {
                            key.DeleteValue(_UsernameValueName);
                            key.DeleteValue(_PasswordValueName);
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static bool IsLoginInformationExist()
        {
            using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
            {
                using (RegistryKey key = baseKey.OpenSubKey(_SubkeyPath, true))
                {
                    return key != null && key.ValueCount > 0;
                }
            }
        }

        public static string GetSavedUsername()
        {
            return Registry.GetValue(_BasekeyPath, _UsernameValueName, null)?.ToString();
        }

        public static string GetSavedPassword()
        {
            return Registry.GetValue(_BasekeyPath, _PasswordValueName, null)?.ToString();
        }

    }
}