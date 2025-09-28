using BusinessLogic.Validation;
using DTOs.Parties;

namespace BusinessLogic.Parties
{
    abstract public class clsParty
    {
        public enum enPartyCategory
        {
            Person = 1,
            Organization = 2
        }

        public enum enPartyType
        {
            Employee = 1,
            Customer = 2,
            Supplier = 3,
            ContactPerson = 4
        }

        public int PartyID { get; }
        public string PartyName { get; set; }
        public enPartyCategory PartyCategory { get; }
        public clsCountry CountryInfo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public clsParty(int partyID, string partyName, enPartyCategory partyCategory, byte countryID, string phone, string email, string address)
        {
            PartyID = partyID;
            PartyName = partyName;
            PartyCategory = partyCategory;
            CountryInfo = clsCountry.Find(countryID);
            Phone = phone;
            Email = email;
            Address = address;
        }

        public virtual clsPartyDTO MappingToDTO()
        {
            return new clsPartyDTO(
                this.PartyID,
                this.PartyName,
                (byte)this.PartyCategory,
                this.CountryInfo.CountryID,
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

            if (!clsValidator.IsValidName(PartyName))
            {
                validationResult.AddError("إسم الكيان", "يجب أن يتكون الإسم من حروف فقط");
            }

            if (CountryInfo is null)
            {
                validationResult.AddError("البلد/الجنسية", "لم يتم العثور على الدولة المختارة");
            }

            if (!clsValidator.IsValidPhone(Phone))
            {
                validationResult.AddError("رقم الهاتف", "رقم الهاتف يجب أن يتكون من 10 أرقام");
            }

            if (!string.IsNullOrEmpty(Email) && !clsValidator.IsValidEmail(Email) || !Email.EndsWith("@gmail.com"))
            {
                validationResult.AddError("البريد الإلكتروني", "تنسيق البريد الإلكتروني غير صحيح");
            }

            return validationResult;
        }

    }
}
