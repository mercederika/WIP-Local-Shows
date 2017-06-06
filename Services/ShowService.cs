using GoogleC29CrudApp.Models.Requests;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GoogleC29CrudApp.Services
{
    public class ShowService
    {

        public static int CreateShow(ShowCreateRequest model)
        {
            int id;

            string connectionString =
                ConfigurationManager.ConnectionStrings
                ["DefaultConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("dbo.Shows_Insert", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameterCollection parameterCollection = command.Parameters;

                    parameterCollection.AddWithValue("@VenueID", model.VenueID);
                    parameterCollection.AddWithValue("@ShowName", model.ShowName);
                    parameterCollection.AddWithValue("@Cost", model.Cost);
                    parameterCollection.AddWithValue("@Date", model.Date);
                    parameterCollection.AddWithValue("@FlyerUrl", model.FlyerUrl);
                    parameterCollection.AddWithValue("@StartTime", model.StartTime);

                    SqlParameter idParameter = new SqlParameter("@ShowID", SqlDbType.Int);
                    idParameter.Direction = ParameterDirection.Output;
                    parameterCollection.Add(idParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    int.TryParse(idParameter.Value.ToString(), out id);
                }

                return id;
            }
        }
    }
}