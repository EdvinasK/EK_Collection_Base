using EK.Common;
using EK_Collection_Base.POJO;
using EK_Collection_Base.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EK_Collection_Base.Entities
{
    public class Client : EntityBase, ILoggable
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

        /// <summary>
        /// Sends an email to a set of clients
        /// </summary>
        /// <param name="clients">Clients to send email to.</param>
        /// <param name="message">Message body to send to clients.</param>
        /// <returns>A list of sent messages after formating.</returns>
        public static List<string> SendEmail(ICollection<Client> clients, string message)
        {
            var confirmations = new List<string>();
            var emailService = new EmailService();


            foreach(var client in clients)
            {
                var subject = $"Important message for: {client.Name}";
                var confirmation = emailService.SendMessage(subject,
                                                            message,
                                                            client.Name);
                confirmations.Add(confirmation);
            }

            return confirmations;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        public string Log()
        {
            var logString = $"Id:{Id}, Name:{Name}";

            return logString;
        }
    }
}
