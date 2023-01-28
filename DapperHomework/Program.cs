using DapperHomework.Repository;

namespace DapperHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var customers = CustomerRepository.GetCustomers();
            foreach (var customer in customers)
                Console.WriteLine($"{customer.Id}:\t{customer.FirstName}\t\t\t\t{customer.LastName}\t\t\t\t{customer.Age}");

            //var unigueName = UniqueNameRepository.GetUniqueName();
            //foreach (var user in unigueName)
            //    Console.WriteLine(user.FirstName);

            Console.WriteLine("\n-----------***------------\n");

            var products = ProductRepository.GetProducts();
            foreach (var product in products)
                Console.WriteLine($"{product.Id}:\t{product.Name}\t{product.Description}\t{product.Price}\t{product.StockQuantity}");

            Console.WriteLine("\n-----------***------------\n");

            var productsFilter = ProductRepository.GetProductsFromToPrice(30, 100);
            foreach (var product in productsFilter)
                Console.WriteLine($"{product.Id}:\t{product.Name}\t{product.Description}\t{product.Price}\t{product.StockQuantity}");

            Console.WriteLine("\n-----------***------------\n");

            var orders = OrdersRepository.GetOrders();
            foreach (var order in orders)
                Console.WriteLine($"{order.Id}:\t{order.CustomerId}\t{order.ProductId}\t{order.Quantity}");


            Console.ReadKey();

        }
    }
}