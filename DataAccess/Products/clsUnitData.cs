using System;
using System.Data.SqlClient;
using System.Data;
using DTOs.Products;

namespace DataAccess.Products
{
    public class clsUnitData
    {
        public static clsUnitDTO FindUnitByID(int unitID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Units_FindByID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UnitID", unitID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsUnitDTO unitDTO = null;

                            if (reader.Read())
                            {
                                unitDTO = new clsUnitDTO
                                {
                                    UnitID = unitID,
                                    UnitName = Convert.ToString(reader["UnitName"]),
                                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                                };


                                unitDTO.UpdatedByUserID = reader["UpdatedByUserID"] == DBNull.Value ?
                                    (int?)null :
                                    (int)reader["UpdatedByUserID"];

                                unitDTO.UpdatedAt = reader["UpdatedAt"] == DBNull.Value ?
                                    (DateTime?)null :
                                    (DateTime)reader["UpdatedAt"];
                            }

                            return unitDTO;
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool AddUnit(clsUnitDTO unitDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Units_InsertUnit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UnitName", unitDTO.UnitName);
                    command.Parameters.AddWithValue("@CreatedByUserID", unitDTO.CreatedByUserID);

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnValueParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        return (int)returnValueParam.Value == 1;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool UpdateUnit(clsUnitDTO unitDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Units_UpdateUnit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UnitID", unitDTO.UnitID);
                    command.Parameters.AddWithValue("@UnitName", unitDTO.UnitName);
                    command.Parameters.AddWithValue("@UpdatedByUserID", unitDTO.UpdatedByUserID);

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnValueParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        return (int)returnValueParam.Value == 1;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool DeleteUnit(int unitID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Units_DeleteUnit",
                "@UnitID",
                unitID
                );
        }

        public static DataTable GetAllUnits()
        {
            return clsDataSettings.GetDataTable(
                "usp_Units_GetAllUnits"
                );
        }

        public static DataTable GetUnitsList()
        {
            return clsDataSettings.GetDataTable(
                "usp_Units_GetUnitsList"
                );
        }

        public static DataTable GetProductUnits(int productID)
        {
            return clsDataSettings.GetDataTable(
                "usp_Units_GetProductUnits",
                "@ProductID",
                productID
                );
        }

        public static bool IsUnitExists(int unitID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Units_IsExistsByID",
                "@UnitID",
                unitID
                );
        }

        public static bool IsUnitExists(string unitName)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Units_IsExistsByName",
                "@UnitName",
                unitName
                );
        }

    }
}
