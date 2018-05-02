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
        private string _mailTo = "fernando.marquardt@dell.com";
        private string _mailFrom = "cityinfo.app@dell.com";

        public void Send(string subject, string message)
        {
            // send mail - output to debug window
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, using CloudMailService.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
