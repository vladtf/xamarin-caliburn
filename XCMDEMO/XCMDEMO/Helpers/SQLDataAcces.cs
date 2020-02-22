using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using XCMDEMO.Models;

namespace XCMDEMO.Helpers
{
    public class SQLDataAcces
    {
        public static string ConnectionString
        {
            get => @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VTFData;" +
                    "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                    "TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public static IEnumerable<PersonModel> GetPeople(string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string cmdText = "Select * from dbo.Employees";

            IEnumerable<PersonModel> output = sqlConnection.Query<PersonModel>(cmdText).ToList();

            return output;
        }
    }
}