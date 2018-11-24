using EK_Collection_Base.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EK_Collection_Base.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public OperationResult<string> ChangeName(string name)
        {
            this.Name = name;
            return new OperationResult<string>(Name, "Name changed");
        }
    }
}
