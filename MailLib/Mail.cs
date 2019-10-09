using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailLib
{
  public  class Mail
    {
        public void SendMail(String email) {
            SmtpClient client = new SmtpClient();
            MailAddress from = new MailAddress("emirogs1@gmail.com");
            MailAddress to = new MailAddress("devim.celik@motion-steel.com");//bizim mail adresi
            MailMessage msg = new MailMessage(from, to);
            msg.IsBodyHtml = true;
            msg.Subject = "Fitkutu Takip Et";
            msg.Body += "<h2> " + email + " </h2> adresli kişi Fitkutuyu takip etmek istiyor "; //burada başında gönderen kişinin mail adresi geliyor
            msg.CC.Add("fitkutu@fitkutu.com");//herkes görür
            NetworkCredential info = new NetworkCredential("emirogs1@gmail.com", "Emrhmrc.95");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = info;
            client.Send(msg);
         
        }
    }
}
