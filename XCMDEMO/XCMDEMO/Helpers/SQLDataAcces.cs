using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using XCMDEMO.Models;

namespace XCMDEMO.Helpers
{
    internal class SQLDataAcces
    {
        public static IEnumerable<PersonModel> GetPeople()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VTFData;" +
                $"Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                $"TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection data = new SqlConnection(connectionString);

            IEnumerable<PersonModel> result = data.Query<PersonModel>("Select * from dbo.Employees").ToList();

            return result;
        }
    }
}