using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EK_Collection_Base.Entities
{
    public class Order
    {
        public string Id { get; set; }
        public int ProductId { get; set; }
        public int OrderItemId { get; set; }
    }
}
