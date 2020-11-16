using System;
using EX2.Entities.Enums;
namespace EX2.Entities

{
    public class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public OrderItem Item { get; set; }

        public Order(){

        }

        public void AddItem(OrderItem item){
            
        }
        
    }
}