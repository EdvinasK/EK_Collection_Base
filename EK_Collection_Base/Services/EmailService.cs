using System;
using System.Collections.Generic;
using System.Text;

namespace EK_Collection_Base.Services
{
    public class EmailService
    {
        public string SendMessage(string subject, string message, string email)
        {
            return $"{subject} : {message} -> {email}";
        }
    }
}
