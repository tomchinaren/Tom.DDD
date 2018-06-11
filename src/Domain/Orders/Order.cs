using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders
{
    public class Order: IAggregateRoot
    {
        public long ID { get; set; }
        private ICollection<OrderItem> _orderItems;

        public void AddOrder()
        {

        }
        public void UpdateOrderStatus()
        {

        }
    }
}
