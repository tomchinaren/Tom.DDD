using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// 创建订单
    /// 更新订单状态
    /// </summary>
    public class OrderService
    {
        private readonly Order _order;
        public OrderService(Order order)
        {
            this._order = order;
        }
    }
}
