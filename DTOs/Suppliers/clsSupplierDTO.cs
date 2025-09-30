using System;

namespace DTOs.Suppliers
{
    public class clsSupplierDTO
    {
        public int? SupplierID { get; set; }
        public string SupplierName { get; set; }
        public byte SupplierCategoryID { get; set; }
        public byte SupplierCountryID { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierAddress { get; set; }

        // Supplier Person Info
        public string SupplierNationalNa { get; set; }
        public DateTime? SupplierBirthDate { get; set; }
        public byte? SupplierGender { get; set; }
        public string SupplierImagePath { get; set; }

        // Contact Person In An Organization
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
        
        // Output Fileds
        public int? PartyID { get; set; }
        public int? PersonID { get; set; }
        public int? OrganizationID { get; set; }
        public int? ContactPersonID { get; set; }
        public int? ContactPersonPartyID { get; set; }

        public clsSupplierDTO() { }

        public clsSupplierDTO(int? supplierID, string supplierName, byte supplierCategoryID,
            byte supplierCountryID, string supplierPhone, string supplierEmail, string supplierAddress,
            string supplierNationalNa, DateTime? supplierBirthDate, byte? supplierGender,
            string supplierImagePath, string contactPersonName, byte? contactPersonCountryID,
            string contactPersonPhone, string contactPersonEmail, string contactPersonAddress, 
            string contactPersonNationalNa, DateTime? contactPersonBirthDate, byte? contactPersonGender,
            string contactPersonImagePath, string supplierNotes, bool isDeleted, int? createdByUserID,
            DateTime? createdAt, int? updatedByUserID, DateTime? updatedAt, int? partyID,
            int? personID, int? organizationID, int? contactPersonID, int? contactPersonPartyID)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            SupplierCategoryID = supplierCategoryID;
            SupplierCountryID = supplierCountryID;
            SupplierPhone = supplierPhone;
            SupplierEmail = supplierEmail;
            SupplierAddress = supplierAddress;
            SupplierNationalNa = supplierNationalNa;
            SupplierBirthDate = supplierBirthDate;
            SupplierGender = supplierGender;
            SupplierImagePath = supplierImagePath;
            ContactPersonName = contactPersonName;
            ContactPersonCountryID = contactPersonCountryID;
            ContactPersonPhone = contactPersonPhone;
            ContactPersonEmail = contactPersonEmail;
            ContactPersonAddress = contactPersonAddress;
            ContactPersonNationalNa = contactPersonNationalNa;
            ContactPersonBirthDate = contactPersonBirthDate;
            ContactPersonGender = contactPersonGender;
            ContactPersonImagePath = contactPersonImagePath;
            SupplierNotes = supplierNotes;
            IsDeleted = isDeleted;
            CreatedByUserID = createdByUserID;
            CreatedAt = createdAt;
            UpdatedByUserID = updatedByUserID;
            UpdatedAt = updatedAt;
            PartyID = partyID;
            PersonID = personID;
            OrganizationID = organizationID;
            ContactPersonID = contactPersonID;
            ContactPersonPartyID = contactPersonPartyID;
        }

    }
}