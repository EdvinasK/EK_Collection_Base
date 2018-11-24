using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EK_Collection_Base.Repositories
{
    public class ClientRepository
    {
        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            // Call the database to retrieve the value
            // If no value is returned, return the default value
            T value = defaultValue;

            return value;
        }

        //public TReturn RetrieveValue<TReturn, TParameter>(string sql, TParameter defaultValue)
        //{
        //    // Call the database to retrieve the value
        //    // If no value is returned, return the default value
        //    TParameter value = defaultValue;
        //    value.

        //    return value;
        //}
    }
}
