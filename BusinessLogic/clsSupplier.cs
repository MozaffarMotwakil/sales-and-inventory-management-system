using System;
using System.Data;
using System.IO;
using DataAccess;
using DTOs;

namespace BusinessLogic
{
    public class clsSupplier
    {
        public class SupplierSavedEventArgs : EventArgs
        {
            public clsSupplier SavedSupplier { get; }
            public enMode OperationMode { get; }
            public DateTime Timestamp { get; }
            public int UserID { get; }

            public SupplierSavedEventArgs(clsSupplier savedSupplier)
            {
                SavedSupplier = savedSupplier;
                OperationMode = savedSupplier._Mode;
                Timestamp = DateTime.Now;
                UserID = clsAppSettings.CurrentUser.UserID;
            }
        }

        public static event EventHandler<SupplierSavedEventArgs> SupplierSaved;

        protected virtual void OnSupplierSaved(clsSupplier savedSupplier)
        {
            SupplierSaved?.Invoke(this, new SupplierSavedEventArgs(savedSupplier));
        }

        public static event Action SupplierDeleted;
        
        protected static void OnSupplierDeleted()
        {
            SupplierDeleted?.Invoke();
        }
        

        public int SupplierID { get; }
        public clsParty PartyInfo { get; set;  }
        public string Notes { get; set; }
        public bool IsDeleted { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime CreatedAt { get; }
        public clsUser UpdatedByUserInfo { get; private set; }
        public DateTime? UpdatedAt { get; }
        private enMode _Mode { get; set; }

        public clsSupplier(clsParty party, string notes)
        {
            this.PartyInfo = party;
            this.Notes = notes;
            this.IsDeleted = false;
            this.CreatedByUserInfo = clsAppSettings.CurrentUser;
            this.UpdatedByUserInfo = clsAppSettings.CurrentUser;
            this._Mode = enMode.Add;
        }

        private clsSupplier(clsSupplierDTO supplierDTO)
        {
            SupplierID = supplierDTO.SupplierID;
            PartyInfo = supplierDTO.PartyCategoryID == 1 ?
                clsPerson.FindByPartyID(supplierDTO.PartyID) :
                (clsParty)clsOrganization.FindByPartyID(supplierDTO.PartyID);
            Notes = supplierDTO.Notes;
            IsDeleted = supplierDTO.IsDeleted;
            CreatedByUserInfo = new clsUser(1);
            CreatedAt = supplierDTO.CreatedAt;
            UpdatedByUserInfo = supplierDTO.UpdatedByUserID != null ?
                new clsUser(1) :
                null;
            UpdatedAt = supplierDTO.UpdatedAt;
            this._Mode = enMode.Update;
        }

        public static clsSupplier Find(int supplierID)
        {
            clsSupplierDTO supplierDTO = clsSupplierData.FindSupplierByID(supplierID);
            return supplierDTO is null ? null : new clsSupplier(supplierDTO);
        }

        public static clsSupplier Find(string supplierName)
        {
            clsSupplierDTO supplierDTO = clsSupplierData.FindSupplierByName(supplierName);
            return supplierDTO is null ? null : new clsSupplier(supplierDTO);
        }

        public static bool Delete(int supplierID)
        {
            clsSupplier supplier = Find(supplierID);
            string imagePath = string.Empty;

            if (supplier.PartyInfo is clsPerson person)
            {
                imagePath = person.CurrentImagePath;
            }

            bool isDeleted = clsSupplierData.DeleteSupplier(supplierID);

            if (isDeleted)
            {
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }

                OnSupplierDeleted();
            }

            return isDeleted;
        }

        public static DataTable GetAllSuppliers()
        {
            return clsSupplierData.GetAllSuppliers();
        }

        public static string[] GetAllSupplierNames()
        {
            DataTable table = clsSupplierData.GetAllSupplierNames();
            string[] supplierNames = new string[table.Rows.Count];

            for (int i = 0; i < supplierNames.Length; i++)
            {
                supplierNames[i] = table.Rows[i][0].ToString();
            }

            return supplierNames;
        }

        public clsValidationResult Save()
        {
            clsValidationResult result = this.Validated();

            if (!result.IsValid)
            {
                return result;
            }

            bool isSaved;

            switch (this._Mode)
            {
                case enMode.Add:
                    switch (this.PartyInfo.PartyCategory)
                    {
                        case clsParty.enPartyCategory.Person:
                            (this.PartyInfo as clsPerson).SaveImage();

                            isSaved = clsSupplierData.AddSupplier(
                                this.PartyInfo.MappingToDTO(), this.MappingToDTO()
                                );

                            if (!isSaved)
                            {
                                result.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                                (this.PartyInfo as clsPerson).DeleteImage();
                            }
                            else
                            {
                                OnSupplierSaved(this);
                            }

                            return result;
                        case clsParty.enPartyCategory.Organization:
                            isSaved = clsSupplierData.AddSupplier(
                                this.PartyInfo.MappingToDTO(), this.MappingToDTO(),
                                (clsPersonDTO)((clsOrganization)PartyInfo).ContactPerson?.MappingToDTO()
                                );

                            if (!isSaved)
                            {
                                result.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                            }
                            else
                            {
                                OnSupplierSaved(this);
                            }

                            return result;
                        default:
                            return result;
                    }
                case enMode.Update:
                    this.UpdatedByUserInfo = clsAppSettings.CurrentUser;

                    switch (PartyInfo.PartyCategory)
                    {
                        case clsParty.enPartyCategory.Person:
                            (this.PartyInfo as clsPerson).SaveImage();

                            isSaved = clsSupplierData.UpdateSupplier(
                                this.PartyInfo.MappingToDTO(), this.MappingToDTO()
                                );

                            if (!isSaved)
                            {
                                result.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                            }
                            else
                            {
                                OnSupplierSaved(this);
                            }

                            return result;
                        case clsParty.enPartyCategory.Organization:
                            isSaved = clsSupplierData.UpdateSupplier(
                                this.PartyInfo.MappingToDTO(), this.MappingToDTO(),
                                (clsPersonDTO)((clsOrganization)PartyInfo).ContactPerson?.MappingToDTO()
                                );

                            if (!isSaved)
                            {
                                result.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                            }
                            else
                            {
                                OnSupplierSaved(this);
                            }

                            return result;
                        default:
                            break;
                    }
                    return result;
                default:
                    return result;
            }
        }

        public clsSupplierDTO MappingToDTO()
        {
            return new clsSupplierDTO(
                this.SupplierID,
                this.PartyInfo.PartyID,
                (byte)this.PartyInfo.PartyCategory,
                this.Notes,
                this.IsDeleted,
                this.CreatedByUserInfo.UserID,
                this.CreatedAt,
                this.UpdatedByUserInfo?.UserID,
                this.UpdatedAt
                );
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult;

            if (PartyInfo is null)
            {
                validationResult = new clsValidationResult();
                validationResult.AddError("الكيان الأساسي", "لا يمكن أن يكون الكيان الأساسي بدون مرجع");
            }
            else
            {
                validationResult = PartyInfo.Validated();
            }

            return validationResult;
        }

    }
}
