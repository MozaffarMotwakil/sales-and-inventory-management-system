using System;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess.Utilities
{
    public class clsActivityLogData
    {
        public static bool InsertNewLog(int userID, int? entityID, int entityTypeID, int activityTypeID, string details)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_InsertNewLog", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@EntityID", entityID);
                    command.Parameters.AddWithValue("@EntityTypeID", entityTypeID);
                    command.Parameters.AddWithValue("@ActivityTypeID", activityTypeID);
                    command.Parameters.AddWithValue("@Details", details);

                    try
                    {
                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error adding new active log to database.", ex);
                    }
                }
            }
        }

    }
}
