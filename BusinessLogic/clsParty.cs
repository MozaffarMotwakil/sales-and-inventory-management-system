using System;
using DTOs;

namespace BusinessLogic
{
    public class clsParty
    {
        public enum enPartyCatigory
        {
            Person = 1,
            Organization = 2
        }

        public int PartyID { get; }
        public string PartyName { get; set; }
        public enPartyCatigory PartyCategory { get; protected set; }
        public byte CountryID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public clsParty() { }

        public clsParty(string partyName, enPartyCatigory partyCategory, byte countryID, string phone, string email, string address)
        {
            PartyName = partyName;
            PartyCategory = partyCategory;
            CountryID = countryID;
            Phone = phone;
            Email = email;
            Address = address;
        }

        public virtual clsPartyDTO MappingToDTO()
        {
            return new clsPartyDTO(
                this.PartyName,
                (byte)this.PartyCategory,
                this.CountryID,
                this.Phone,
                this.Email,
                this.Address
                );
        }

        public virtual clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();

            if (string.IsNullOrWhiteSpace(PartyName))
            {
                validationResult.AddError("إسم الكيان", "لا يمكن أن يكون إسم الكيان الأساسي فارغا");
            }

            if (!clsValidator.IsValidPhone(Phone))
            {
                validationResult.AddError("رقم الهاتف", "رقم الهاتف يجب أن يتكون من 10 أرقام");
            }

            if (!string.IsNullOrEmpty(Email) && !clsValidator.IsValidEmail(Email))
            {
                validationResult.AddError("البريد الإلكتروني", "تنسيق البريد الإلكتروني غير صحيح");
            }

            return validationResult;
        }

    }
}
