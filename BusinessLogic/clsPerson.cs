using System;
using System.IO;
using System.Net;
using System.Security.Policy;
using DTOs;

namespace BusinessLogic
{
    public class clsPerson : clsParty
    {
        public enum enGender 
        {
            Male,
            Female
        }

        public string NationalNa { get; set; }
        public DateTime BirthDate { get; set; }
        public enGender Gender { get; set; }
        public string CurrentImagePath { get; private set; }
        public string NewImagePath { get; set; }

        public clsPerson(string personName, byte countryID, string phone, string email, string address,
            string nationalNa, DateTime birthDate, enGender gender, string imagePath)
        {
            PartyName = personName;
            PartyCategory = enPartyCatigory.Person;
            CountryInfo = clsCountry.Find(countryID);
            Phone = phone;
            Email = email;
            Address = address;
            NationalNa = nationalNa;
            BirthDate = birthDate;
            Gender = gender;
            NewImagePath = imagePath;
        }

        private clsPerson(clsPersonDTO personDTO)
        {
            PartyID = personDTO.PartyID;
            PartyName = personDTO.PartyName;
            PartyCategory = (enPartyCatigory)personDTO.PartyCategoryID;
            CountryInfo = clsCountry.Find(personDTO.CountryID);
            Phone = personDTO.Phone;
            Email = personDTO.Email;
            Address = personDTO.Address;
            NationalNa = personDTO.NationalNa;
            BirthDate = personDTO.BirthDate;
            Gender = personDTO.Gender ? enGender.Female : enGender.Male;
            CurrentImagePath = personDTO.ImagePath;
            NewImagePath = personDTO.ImagePath;
        }

        public void DeleteImage()
        {
            if (File.Exists(this.CurrentImagePath))
            {
                File.Delete(this.CurrentImagePath);
            }

            this.CurrentImagePath = string.Empty;
        }

        public void SaveImage()
        {
            if (string.IsNullOrEmpty(NewImagePath))
            {
                this.DeleteImage();
                return;
            }
            else
            {
                if (NewImagePath != this.CurrentImagePath)
                {
                    this.DeleteImage();
                    this.CurrentImagePath = clsAppSettings.GetNewImagePathWithGUID();
                    File.Copy(NewImagePath, this.CurrentImagePath);
                }
            }
        }

        public override clsPartyDTO MappingToDTO()
        {
            return new clsPersonDTO(
                this.PartyID,
                this.PartyName,
                (byte)this.PartyCategory,
                this.CountryInfo.CountryID,
                this.Phone,
                this.Email,
                this.Address,
                this.NationalNa,
                this.BirthDate,
                this.Gender == enGender.Male ? false : true,
                this.CurrentImagePath
                );
        }

        public override clsValidationResult Validated()
        {
            clsValidationResult orginalPartyValidationResult = base.Validated();

            // يتم إضافة هذه الميزة لاحقا
            //if (IsNationalNaExist(NationalNa))
            //{
            //    validationResult.AddError("الرقم الوطني", "الرقم الوطني موجود بالفعل");
            //}

            if (BirthDate > DateTime.Today)
            {
                orginalPartyValidationResult.AddError("تاريخ الميلاد", "لا يمكن أن يكون تاريخ الميلاد في المستقبل");
            }

            return orginalPartyValidationResult;
        }

    }
}
