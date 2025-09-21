using System;
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
        public string ImagePath { get; set; }

        public clsPerson(string personName, byte countryID, string phone, string email, string address,
            string nationalNa, DateTime birthDate, enGender gender, string imagePath)
        {
            PartyName = personName;
            PartyCategory = enPartyCatigory.Person;
            CountryID = countryID;
            Phone = phone;
            Email = email;
            Address = address;
            NationalNa = nationalNa;
            BirthDate = birthDate;
            Gender = gender;
            ImagePath = imagePath;
        }

        public override clsPartyDTO MappingToDTO()
        {
            return new clsPersonDTO(
                this.PartyID,
                this.PartyName,
                (byte)this.PartyCategory,
                this.CountryID,
                this.Phone,
                this.Email,
                this.Address,
                this.NationalNa,
                this.BirthDate,
                this.Gender == enGender.Male ? false : true,
                this.ImagePath
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
