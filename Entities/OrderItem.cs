namespace EX2.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; }

        public OrderItem(int quantity, double price){
            Quantity = quantity;
            Price = price;
        }
        
        public double SubTotal(){
            return Quantity * Price;
        }
    }
}