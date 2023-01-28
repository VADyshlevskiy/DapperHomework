using Dapper;
using DapperHomework;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperHomework.Repository
{
    public class OrdersRepository
    {
        public static List<Orders> GetOrders()
        {
            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = $"select  id, CustomerId, ProductId, Quantity from orders";
                return connection.Query<Orders>(sql).ToList();
            }
        }
    }
}