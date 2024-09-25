using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MINEDU.IEST.Estudiante.Inf_Utils.Dtos;

namespace MINEDU.IEST.Estudiante.Inf_Utils.Helpers.EmailSender
{
    public class EmailTacama : IEmailSender
    {

        private readonly MailSettings _mailSettings;
        private readonly ResourceDto _resourceDto;

        public EmailTacama(MailSettings mailSettings, ResourceDto resourceDto)
        {
            _mailSettings = mailSettings;
            _resourceDto = resourceDto;
        }

        public async Task SendEmailAsync(Message message)
        {
            var mailMessage = CreateEmailMessage(message);
            await SendAsync(mailMessage);
        }
       

        private async Task SendAsync(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync(_mailSettings.ServidorCorreo, Convert.ToInt32(_mailSettings.PuertoServidor), SecureSocketOptions.StartTls);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    await client.AuthenticateAsync(_mailSettings.UsuarioCorreo, _mailSettings.PasswordCorreo);
                    await client.SendAsync(mailMessage);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    await client.DisconnectAsync(true);
                    client.Dispose();
                }
            }
        }

        private MimeMessage CreateEmailMessage(Message message)
        {
            try
            {
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress("TACAMA", _mailSettings.UsuarioCorreo));
                emailMessage.To.AddRange(message.To);
                emailMessage.Subject = message.Subject;
                var fileHtmlPath = "Resources/template-correo/template-email.html";
                string bodyHtml = string.Empty;

                using (StreamReader SourceReader = System.IO.File.OpenText(fileHtmlPath))
                {
                    bodyHtml = SourceReader.ReadToEnd();

                }
                var bodyBuilder = new BodyBuilder { HtmlBody = getHtmlBody(bodyHtml, message.Content.ToArray()) };

                if (message.Attachments != null && message.Attachments.Any())
                {
                    byte[] fileBytes;
                    foreach (var attachment in message.Attachments)
                    {
                        //using (var ms = new MemoryStream())
                        //{
                        //    attachment.CopyTo(ms);
                        //    fileBytes = ms.ToArray();
                        //}

                        //bodyBuilder.Attachments.Add(attachment.FileName, fileBytes, ContentType.Parse(attachment.ContentType));
                        bodyBuilder.Attachments.Add(attachment.FileName, attachment.Content, ContentType.Parse(attachment.ContentType));
                    }
                }
                emailMessage.Body = bodyBuilder.ToMessageBody();

                return emailMessage;
            }
            catch (Exception ex)
            {
                //logger.LogError(ex.Message);
                throw ex;
            }
        }


        private string getHtmlBody(string body, string[] model)
        {
            body = body.Replace("{nro-cotizacion}", model[0].ToString());
            body = body.Replace("{nombre-empresa}", model[1].ToString());
            return body;
        }

        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            throw new NotImplementedException();
        }

        public Task SendEmailRestauraClaveAsync(Message message)
        {
            throw new NotImplementedException();
        }


    }
}
