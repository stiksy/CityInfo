using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private string _mailTo = Startup.Configuration["MAIL_TOADDRESS"];
        private string _mailFrom = Startup.Configuration["MAIL_FROMADDRESS"];

        public void Send(string subject, string message)
        {
            // send mail - output to debug window
            Console.WriteLine($"[DEBUG] Mail from {_mailFrom} to {_mailTo}, using LocalMailService.");
            Console.WriteLine($"[DEBUG] Subject: {subject}");
            Console.WriteLine($"[DEBUG] Message: {message}");
        }
    }
}
