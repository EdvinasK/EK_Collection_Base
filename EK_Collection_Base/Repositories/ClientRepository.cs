using EK_Collection_Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EK_Collection_Base.Repositories
{
    public class ClientRepository
    {
        private List<Client> Clients;

        /// <summary>
        /// Retrieves all of the approved clients
        /// </summary>
        /// <returns></returns>
        public ICollection<Client> Retrieve()
        {
            if(Clients == null)
            {
                Clients = new List<Client>
                {
                    new Client { Id = 1, Name = "Ross" },
                    new Client { Id = 2, Name = "Rachel" }
                };
            }

            Clients.ForEach(c => Console.WriteLine(c));
            Console.WriteLine(Clients[0]);

            return Clients;
        }

        /// <summary>
        /// Retrieves all of the approved clients
        /// </summary>
        /// <returns></returns>
        public Client[] RetrieveArray()
        {
            var Clients = new Client[2]
            {
                new Client() { Id = 1, Name = "Ross" },
                new Client() { Id = 2, Name = "Rachel" }
            };

            return Clients;
        }

        public Dictionary<string, Client> RetrieveWithKeys()
        {
            var clients = new Dictionary<string, Client>()
            {
                { "Ross", new Client { Id = 1, Name = "Ross" } },
                { "Rachel", new Client { Id = 2, Name = "Rachel" } }
            };

            foreach (var element in clients)
            {
                var client = element.Value;
                var key = element.Key;
                Console.WriteLine($"Key: {key} Value: {client}");
            }

            foreach (var clientValue in clients.Values)
            {
                Console.WriteLine(clientValue);
            }

            foreach(var clientKey in clients.Keys)
            {
                Console.WriteLine(clients[clientKey]);
            }

            if(clients.ContainsKey("Joe"))
                Console.WriteLine(clients["Joe"]);

            Client sampleClient;

            if (clients.TryGetValue("Joe", out sampleClient))
                Console.WriteLine(sampleClient);

            return clients;
        }

        public T RetrieveValue<T>(string sql, T defaultValue) where T : struct
        {
            // Call the database to retrieve the value
            // If no value is returned, return the default value
            T value = defaultValue;

            return value;
        }

        /// <summary>
        /// Overload of the generic type since its restricted to struct(Value types)
        /// </summary>
        /// <param name="sql">SQL query in string format.</param>
        /// <param name="defaultValue">Default value if no value was found.</param>
        /// <returns></returns>
        public string RetrieveValue(string sql, string defaultValue)
        {
            // Call the database to retrieve the value
            // If no value is returned, return the default value
            var value = defaultValue;

            return value;
        }

        /// <summary>
        /// Populates DB with a new element.
        /// </summary>
        /// <typeparam name="T">New element type.</typeparam>
        /// <param name="sql">SQL query in string format.</param>
        /// <returns></returns>
        public T Populate<T>(string sql) where T : class, new()
        {
            T instance = new T();

            return instance;
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
