using System;

namespace DTOs
{
    public class clsSupplierDTO
    {
        public int SupplierID { get; set; }
        public int PartyID { get; set; }
        public string Notes { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedByUserID { get; set; }
        public DateTime UpdatedAt { get; set; }

        public clsSupplierDTO() { }

        public clsSupplierDTO(int supplierID, int partyID, string notes, bool isDeleted, int createdByUserID, DateTime createdAt, int updatedByUserID, DateTime updatedAt)
        {
            SupplierID = supplierID;
            PartyID = partyID;
            Notes = notes;
            IsDeleted = isDeleted;
            CreatedByUserID = createdByUserID;
            CreatedAt = createdAt;
            UpdatedByUserID = updatedByUserID;
            UpdatedAt = updatedAt;
        }
    }
}
