using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class SendMail
    {
        public void GmailSendMail(string subject, string body, string email)
        {
            EmailAddressValidator.IsEmailValid(email);
        }

    }

    public static class EmailAddressValidator
    {
        public static void IsEmailValid(string email)
        {
            //control
            //throw new Exception("Email is not valid.");
        }
    }
}
