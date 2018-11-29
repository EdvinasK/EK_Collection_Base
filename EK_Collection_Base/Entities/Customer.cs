using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EK_Collection_Base.Entities
{
    public class Customer
    {
        public Customer() : this(Guid.NewGuid().ToString())
        {

        }

        public Customer(string Id)
        {
            this.Id = Id;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
