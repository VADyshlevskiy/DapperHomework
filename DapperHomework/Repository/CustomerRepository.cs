using Dapper;
using DapperHomework;
using DapperHomework.Tables;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DapperHomework.Repository
{
    public class CustomerRepository
    {
        public static List<Customers> GetCustomers()
        {
            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = $"select  id, firstname, lastname, age from customers";
                return connection.Query<Customers>(sql).ToList();
            }
        }
    }
}
