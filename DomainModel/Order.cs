using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    public class Order : BaseModel
    {
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public OrderStatus Status { get; set; }
        public Order()
        {
            OrderProducts = new List<OrderProduct>();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Id->{0}\nUserId->{1}\n", this.Id, this.UserId));
            sb.Append("Order products:\n");
            foreach (OrderProduct product in OrderProducts)
            {
                sb.Append(OrderProducts.ToString());
            }
            return sb.ToString();
        }
    }
}
