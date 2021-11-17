using System;
using exercicio_composicao_e_enumeração.Entites;

namespace exercicio_composição_e_enumeração
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date(DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthdate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many itms to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Product name #{i}:");
                string nome = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(nome, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);
                
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary:");
            Console.WriteLine(order);
                
            

        }
    }
}
