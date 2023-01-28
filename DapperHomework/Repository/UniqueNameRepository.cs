using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperHomework.Repository

{
    public class UniqueNameRepository
    {
        public static List<Customers> GetUniqueName()
        {
            var query = @" select
                distinct firstName
                from customers";

            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                //var s = connection.Query<Student>(query, new { id=studentId }).FirstOrDefault();
                var s = connection.Query<Customers>(query).ToList();
               return s;
            }
        }
    }
}
