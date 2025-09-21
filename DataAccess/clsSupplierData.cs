using System;
using System.Data.SqlClient;
using DTOs;

namespace DataAccess
{
    public static class clsSupplierData
    {
        public static bool AddSupplier(clsPartyDTO orginalPartyDTO, clsSupplierDTO supplierDTO, clsPersonDTO contactPersonDTO = null)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_AddSupplier", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // Orginal Party
                    command.Parameters.AddWithValue("@OrginalPartyName", orginalPartyDTO.PartyName);
                    command.Parameters.AddWithValue("@OrginalPartyCategoryID", orginalPartyDTO.PartyCategoryID);
                    command.Parameters.AddWithValue("@OrginalCountryID", orginalPartyDTO.CountryID);
                    command.Parameters.AddWithValue("@OrginalPhone", orginalPartyDTO.Phone);
                    command.Parameters.AddWithValue("@OrginalEmail",
                        string.IsNullOrWhiteSpace(orginalPartyDTO.Email) ? DBNull.Value : (object)orginalPartyDTO.Email);
                    command.Parameters.AddWithValue("@OrginalAddress", 
                        string.IsNullOrWhiteSpace(orginalPartyDTO.Address) ? DBNull.Value : (object)orginalPartyDTO.Address);

                    // Orginal Party is a person. 
                    clsPersonDTO orginalPersonDTO = orginalPartyDTO as clsPersonDTO;
                    command.Parameters.AddWithValue("@OrginalNationalNa",
                        string.IsNullOrWhiteSpace(orginalPersonDTO?.NationalNa) ? DBNull.Value : (object)orginalPersonDTO?.NationalNa);
                    command.Parameters.AddWithValue("@OrginalBirthDate", (object)orginalPersonDTO?.BirthDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@OrginalGender", (object)orginalPersonDTO?.Gender ?? DBNull.Value);
                    command.Parameters.AddWithValue("@OrginalImagePath",
                        string.IsNullOrWhiteSpace(orginalPersonDTO?.ImagePath) ? DBNull.Value : (object)orginalPersonDTO?.ImagePath);

                    // Contact Person details when orginal party is a organization.
                    command.Parameters.AddWithValue("@ContactPersonName", (object)contactPersonDTO?.PartyName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonCountryID", (object)contactPersonDTO?.CountryID ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonPhone", (object)contactPersonDTO?.Phone ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonEmail", 
                        string.IsNullOrWhiteSpace(contactPersonDTO?.Email) ? DBNull.Value : (object)contactPersonDTO?.Email);
                    command.Parameters.AddWithValue("@ContactPersonAddress", 
                        string.IsNullOrWhiteSpace(contactPersonDTO?.Address) ? DBNull.Value : (object)contactPersonDTO?.Address);
                    command.Parameters.AddWithValue("@ContactPersonNationalNa",
                        string.IsNullOrWhiteSpace(contactPersonDTO?.NationalNa) ? DBNull.Value : (object)contactPersonDTO?.NationalNa);
                    command.Parameters.AddWithValue("@ContactPersonBirthDate", (object)contactPersonDTO?.BirthDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonGender", (object)contactPersonDTO?.Gender ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ContactPersonImagePath",
                        string.IsNullOrWhiteSpace(contactPersonDTO?.ImagePath) ? DBNull.Value : (object)contactPersonDTO?.ImagePath);

                    // Supplier
                    command.Parameters.AddWithValue("@SupplierNotes",
                        string.IsNullOrWhiteSpace(supplierDTO?.Notes) ? DBNull.Value : (object)supplierDTO?.Notes);
                    command.Parameters.AddWithValue("@CreatedByUserID", supplierDTO.CreatedByUserID);

                    try
                    {
                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error adding supplier to database.", ex);
                    }
                }
            }
        }

    }
}
