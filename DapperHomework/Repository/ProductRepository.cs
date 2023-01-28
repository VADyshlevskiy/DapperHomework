using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DapperHomework.Repository
{
    public class ProductRepository
    {
        public static List<Products> GetProducts()
        {
            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = $"select id, name, stockquantity, price from products";
                return connection.Query<Products>(sql).ToList();
            }
        }

        public static List<Products> GetProductsFromToPrice(int minPrice = 0, int maxPrice = int.MaxValue)
        {
            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = $"select id, name, stockquantity, price from products where price < {maxPrice} and price > {minPrice}";
                return connection.Query<Products>(sql).ToList();
            }
        }

    }
}