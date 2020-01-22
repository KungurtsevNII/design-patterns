using System.Net.Mail;
using System.Text;

namespace Builder.App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var mailMessage = new MailMessageBuilder()
                .From("test@mail.ru")
                .To("test2@mail.ru")
                .Body("Тест", Encoding.Default)
                .Build();
            
            
            //new SmtpClient().Send(mailMessage);
        }
    }
}