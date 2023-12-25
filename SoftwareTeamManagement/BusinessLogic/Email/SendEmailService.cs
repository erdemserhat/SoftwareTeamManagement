using SoftwareTeamManagement.Constants;
using SoftwareTeamManagement.UI.CustomMessageBox;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

public static class SendEmailService
{
    public static bool SendMail(string recipientEmail, string subject, string body)
    {
        try
        {
            string smtpServer = "smtp.gmail.com"; 
            int smtpPort = 587; 
            string smtpUsername = EmailSender.Email;
            string smtpPassword = EmailSender.Password;


            string fromEmail = EmailSender.Email; 
         
           
            MailMessage mail = new MailMessage(fromEmail, recipientEmail, subject, body);

   
            SmtpClient smtpClient = new SmtpClient(smtpServer)
            {
                Port = smtpPort,
                Credentials = new NetworkCredential(smtpUsername, smtpPassword),
                EnableSsl = true, 
            };

           
            smtpClient.Send(mail);

           
            return true;
        }
        catch (Exception ex)
        {
            return false;
            CustomErrorMessageBoxForm custom = new CustomErrorMessageBoxForm("An error occurred while sending the email: " + ex.Message);
      
        }
        
    }
}
