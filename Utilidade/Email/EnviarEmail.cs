using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Projeto.Utilidade.Email
{
    public class EnviarEmail
    {
        
        public bool SendMail(string email)
        {
            
            try
            {

                // Estancia da Classe de Mensagem
                MailMessage _mailMessage = new MailMessage();
                
                // Remetente
                _mailMessage.From = new MailAddress("EMAIL DE ENVIO");

                // Destinatario seta no metodo abaixo

                //Contrói o MailMessage
                _mailMessage.CC.Add(email);
                _mailMessage.Subject = "Compra de Ingresso";
                _mailMessage.IsBodyHtml = true;
                _mailMessage.Body = "Seu ingresso foi comprado com sucesso";

                //CONFIGURAÇÃO COM PORTA
                SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));

                //CONFIGURAÇÃO SEM PORTA
                 //SmtpClient _smtpClient = new SmtpClient(UtilRsource.ConfigSmtp);

                // Credencial para envio por SMTP Seguro (Quando o servidor exige autenticação)
                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential("LOGIN EMAIL", "SENHA");

                _smtpClient.EnableSsl = true;

                _smtpClient.Send(_mailMessage);

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
