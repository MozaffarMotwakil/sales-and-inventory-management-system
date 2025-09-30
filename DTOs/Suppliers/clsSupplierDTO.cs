using System;
using DTOs.Parties;

namespace DTOs.Suppliers
{
    public class clsSupplierDTO
    {
        public int? PartyID { get; set; }
        public int? SupplierID { get; set; }
        public string SupplierName { get; set; }
        public byte SupplierCategoryID { get; set; }
        public byte SupplierCountryID { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierAddress { get; set; }

        // Supplier Person Info
        public int? PersonID { get; set; }
        public string SupplierNationalNa { get; set; }
        public DateTime? SupplierBirthDate { get; set; }
        public byte? SupplierGender { get; set; }
        public string SupplierImagePath { get; set; }

        // Contact Person In An Organization
        public int? OrganizationID { get; set; }
        public int? ContactPersonID { get; set; }
        public int? ContactPersonPartyID { get; set; }
        public string ContactPersonName { get; set; }
        public byte? ContactPersonCountryID { get; set; }
        public string ContactPersonPhone { get; set; }
        public string ContactPersonEmail { get; set; }
        public string ContactPersonAddress { get; set; }
        public string ContactPersonNationalNa { get; set; }
        public DateTime? ContactPersonBirthDate { get; set; }
        public byte? ContactPersonGender { get; set; }
        public string ContactPersonImagePath { get; set; }

        // Supplier Table Fileds
        public string SupplierNotes { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreatedByUserID { get; set; } 
        public DateTime? CreatedAt { get; set; }
        public int? UpdatedByUserID { get; set; } 
        public DateTime? UpdatedAt { get; set; }

        public clsSupplierDTO() { }

        public clsSupplierDTO(clsPartyDTO partyDTO, int? supplierID, string supplierNotes, bool isDeleted, int? createdByUserID,
            DateTime? createdAt, int? updatedByUserID, DateTime? updatedAt)
        {
            clsPersonDTO personDTO = null;
            clsOrganizationDTO organizationDTO = null;

            if (partyDTO.PartyCategoryID == 1)
            {
                personDTO = partyDTO as clsPersonDTO;
            }
            else
            {
                organizationDTO = partyDTO as clsOrganizationDTO;
            }

            SupplierID = supplierID;
            PartyID = partyDTO.PartyID;
            SupplierName = partyDTO.PartyName;
            SupplierCategoryID = partyDTO.PartyCategoryID;
            SupplierCountryID = partyDTO.CountryID;
            SupplierPhone = partyDTO.Phone;
            SupplierEmail = partyDTO.Email;
            SupplierAddress = partyDTO.Address;
            PersonID = personDTO?.PersonID;
            SupplierNationalNa = personDTO?.NationalNa;
            SupplierBirthDate = personDTO?.BirthDate;
            SupplierGender = personDTO?.Gender;
            SupplierImagePath = personDTO?.ImagePath;
            OrganizationID = organizationDTO?.OrganizationID;
            ContactPersonID = organizationDTO?.ContactPersonID;
            ContactPersonPartyID = organizationDTO?.ContactPersonPartyID;
            ContactPersonName = organizationDTO?.ContactPersonName;
            ContactPersonCountryID = organizationDTO?.ContactPersonCountryID;
            ContactPersonPhone = organizationDTO?.ContactPersonPhone;
            ContactPersonEmail = organizationDTO?.ContactPersonEmail;
            ContactPersonAddress = organizationDTO?.ContactPersonAddress;
            ContactPersonNationalNa = organizationDTO?.ContactPersonNationalNa;
            ContactPersonBirthDate = organizationDTO?.ContactPersonBirthDate;
            ContactPersonGender = organizationDTO?.ContactPersonGender;
            ContactPersonImagePath = organizationDTO?.ContactPersonImagePath;
            SupplierNotes = supplierNotes;
            IsDeleted = isDeleted;
            CreatedByUserID = createdByUserID;
            CreatedAt = createdAt;
            UpdatedByUserID = updatedByUserID;
            UpdatedAt = updatedAt;
        }

    }
}