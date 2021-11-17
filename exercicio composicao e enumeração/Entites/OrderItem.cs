using System.Globalization;

namespace exercicio_composicao_e_enumeração.Entites
{
    class OrderItem
    {
        public double Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        
        public OrderItem()
        {
        }

        public OrderItem(double quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        
        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Nome
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
