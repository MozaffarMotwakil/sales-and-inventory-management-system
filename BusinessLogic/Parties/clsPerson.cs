using System;
using System.IO;
using BusinessLogic.Validation;
using DataAccess.Parties;
using DTOs.Parties;

namespace BusinessLogic.Parties
{
    public class clsPerson : clsParty
    {
        public enum enGender 
        {
            Male,
            Female
        }

        public int? PersonID { get; }
        private string _CurrentNationalNa { get; set; }
        public string NationalNa { get; set; }
        public DateTime BirthDate { get; set; }
        public enGender Gender { get; set; }
        private string _CurrentImagePath { get; set; }
        public string ImagePath { get; set; }

        public clsPerson(string personName, byte countryID, string phone, string email, string address,
            string nationalNa, DateTime birthDate, enGender gender, string imagePath) :
            base(null, personName, enPartyCategory.Person, countryID, phone, email, address)
        {
            PersonID = null;
            _CurrentNationalNa = null;
            NationalNa = nationalNa;
            BirthDate = birthDate;
            Gender = gender;
            _CurrentImagePath = null;
            ImagePath = imagePath;
        }
        private clsPerson(clsPersonDTO personDTO) :
            base(personDTO.PartyID, personDTO.PartyName, enPartyCategory.Person, personDTO.CountryID, 
                personDTO.Phone, personDTO.Email, personDTO.Address)
        {
            PersonID = personDTO.PersonID;
            _CurrentNationalNa = personDTO.NationalNa;
            NationalNa = personDTO.NationalNa;
            BirthDate = personDTO.BirthDate;
            Gender = personDTO.Gender.HasValue ?
                (personDTO.Gender.Value == 0 ? enGender.Male : enGender.Female) :
                enGender.Male;
            _CurrentImagePath = personDTO.ImagePath;
            ImagePath = personDTO.ImagePath;
        }

        public static clsPerson FindByPartyID(int partyID)
        {
            if (partyID < 1)
            {
                return null;
            }

            clsPersonDTO personDTO = clsPersonData.FindPersonByPartyID(partyID);
            return personDTO is null ? null : new clsPerson(personDTO);
        }

        public static clsPerson FindByPersonID(int personID)
        {
            if (personID < 1)
            {
                return null;
            }

            clsPersonDTO personDTO = clsPersonData.FindPersonByPersonID(personID);
            return personDTO is null ? null : new clsPerson(personDTO);
        }

        public void ChangePersonInfo(clsPerson newPersonInfo)
        {
            if (newPersonInfo is null)
            {
                return;
            }

            PartyName = newPersonInfo.PartyName;
            CountryInfo = newPersonInfo.CountryInfo;
            Phone = newPersonInfo.Phone;
            Email = newPersonInfo.Email;
            Address = newPersonInfo.Address;
            NationalNa = newPersonInfo.NationalNa;
            BirthDate = newPersonInfo.BirthDate;
            Gender = newPersonInfo.Gender;
            ImagePath = newPersonInfo.ImagePath;
        }

        public void DeleteImage()
        {
            if (File.Exists(this._CurrentImagePath))
            {
                File.Delete(this._CurrentImagePath);
            }

            this._CurrentImagePath = string.Empty;
        }

        public void SaveImage()
        {
            if (_CurrentImagePath != ImagePath)
            {
                if (string.IsNullOrEmpty(ImagePath))
                {
                    this.DeleteImage();
                }
                else
                {
                    if (!string.IsNullOrEmpty(_CurrentImagePath))
                    {
                        this.DeleteImage();
                    }

                    this._CurrentImagePath = clsAppSettings.GetNewImagePathWithGUIDForPeople();
                    File.Copy(ImagePath, this._CurrentImagePath);
                    this.ImagePath = this._CurrentImagePath;
                }
            }
        }

        public override clsPartyDTO MappingToDTO()
        {
            return new clsPersonDTO(
                this.PartyID,
                this.PartyName.Trim(),
                (byte)this.PartyCategory,
                this.CountryInfo.CountryID,
                this.Phone.Trim(),
                this.Email.Trim(),
                this.Address.Trim(),
                this.PersonID,
                this.NationalNa.Trim(),
                this.BirthDate,
                (byte?)(this.Gender),
                this._CurrentImagePath
                );
        }

        public override clsValidationResult Validated()
        {
            clsValidationResult orginalPartyValidationResult = base.Validated();

            if (_CurrentNationalNa != NationalNa && !(string.IsNullOrEmpty(NationalNa)) && clsValidator.IsNationalNaExists(NationalNa))
            {
                orginalPartyValidationResult.AddError("الرقم الوطني", "الرقم الوطني موجود بالفعل");
            }

            if (BirthDate > DateTime.Today)
            {
                orginalPartyValidationResult.AddError("تاريخ الميلاد", "لا يمكن أن يكون تاريخ الميلاد في المستقبل");
            }

            return orginalPartyValidationResult;
        }

    }
}
