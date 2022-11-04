using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThanksPage : ContentPage
    {
        public ThanksPage()
        {
            InitializeComponent();

            //String pointTotal = (String) MainPage.Fiche.PointTotal;
            pointTotal.Text = pointTotal.Text + " " + MainPage.Fiche.PointTotal;
        }
        private void SendEmail()
        {
            string subject = "subject here ";
            string body = "body here ";
            var mail = new MailMessage();
            var smtpServer = new SmtpClient("smtp.gmail.com", 587);
            mail.From = new MailAddress("fanymamto@gmail.com");
            mail.To.Add("fanymamto@yahoo.fr");
            mail.Subject = subject;
            mail.Body = body;
            System.Net.Mail.Attachment attachment;
            String fileName= @"C:\Users\Fanelle\source\repos\TSRTest.txt";
            attachment = new Attachment(fileName);
            ///data/user/0/com.companyname.tsr/files/TSR/TSR.xlsx

            //attachment = new Attachment();
            mail.Attachments.Add(attachment);
            smtpServer.Credentials = new NetworkCredential("fanymamto@gmail.com", "Orlann27");

            smtpServer.UseDefaultCredentials = false;
            smtpServer.EnableSsl = true;
            smtpServer.Send(mail);

        }

        async void retourPageAccueil_Clicked(object sender, EventArgs e)
        {
   
            this.SendEmail();

            await this.Navigation.PushAsync(new ContactPage());
        }
    }
}