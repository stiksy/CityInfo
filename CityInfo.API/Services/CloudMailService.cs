using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private string _mailTo = Startup.Configuration["MAIL_TOADDRESS"];
        private string _mailFrom = Startup.Configuration["MAIL_FROMADDRESS"];

        public void Send(string subject, string message)
        {
            // send mail - output to debug window
            Console.WriteLine($"[RELEASE] Mail from {_mailFrom} to {_mailTo}, using CloudMailService.");
            Console.WriteLine($"[RELEASE] Subject: {subject}");
            Console.WriteLine($"[RELEASE] Message: {message}");
        }
    }
}
