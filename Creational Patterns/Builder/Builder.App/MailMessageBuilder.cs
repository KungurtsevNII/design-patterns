using System;
using System.Net.Mail;
using System.Text;

namespace Builder.App
{
    /// <summary>
    /// Cтроитель отделяет конструирование сложного объекта от его представления,
    /// так что в результате одного и того же процесса конструирования могут получаться разные представления.
    /// </summary>
    public sealed class MailMessageBuilder
    {
        /// <summary>
        /// Объект эл. письма, который мы кастомизируем.
        /// </summary>
        private readonly MailMessage _mailMessage = new MailMessage();

        public MailMessageBuilder From(string from)
        {
            _mailMessage.From = new MailAddress(from);
            return this;
        }

        public MailMessageBuilder To(string to)
        {
            _mailMessage.To.Add(new MailAddress(to));
            return this;
        }
        
        public MailMessageBuilder Cc(string address)
        {
            _mailMessage.CC.Add(address);
            return this;
        }
        public MailMessageBuilder Subject(string subject)
        {
            _mailMessage.Subject = subject;
            return this;
        }

        public MailMessageBuilder Body(string body, Encoding encoding)
        {
            _mailMessage.Body = body;
            _mailMessage.BodyEncoding = encoding;
            return this;
        }

        public MailMessage Build()
        {
            if (_mailMessage.To.Count == 0)
            {
                throw new InvalidOperationException("Can't create a mail message with empty To. Please call 'To' method first");
            }
            
            return _mailMessage;
        }
    }
}