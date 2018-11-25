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

        public override string ToString()
        {
            return $"{Name}({Id})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            //Client compareClient = obj as Client;

            if (obj is Client compareClient &&
                this.Id == compareClient.Id &&
                this.Name == compareClient.Name)
                return true;

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
