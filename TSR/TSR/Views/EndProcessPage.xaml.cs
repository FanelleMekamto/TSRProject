using System;

using Syncfusion.XlsIO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TSR.DAL;
using System.IO;
using System.Net.Mail;
using System.Net;
using Aspose.Cells;
using CsvHelper;
using System.Text;
using System.Globalization;
using System.Reflection;

[assembly: Dependency(typeof(ISave))]
namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EndProcessPage : ContentPage
    {
        FicheCandidat fiche = MainPage.Fiche;
        public EndProcessPage()
        {
            InitializeComponent();
        }
     
        private void SaveFile()
        {
            // Folder, where a file is created.  
            // Make sure to change this folder to your own folder  
            string folder = @"E:\Old course\Download\TSR\";
            // Filename  
            string fileName = "TSRTest.txt";
            // Fullpath. You can direct hardcode it if you like.  
            string fullPath = folder + fileName;
            // An array of strings  
            string[] authors = {"Mahesh Chand", "Allen O'Neill", "David McCarter", "Raj Kumar", "Dhananjay Kumar"};
            // Write array of strings to a file using WriteAllLines.  
            // If the file does not exists, it will create a new file.  
            // This method automatically opens the file, writes to it, and closes file  
            File.WriteAllLines(fullPath, authors);
            // Read a file  
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);



            /*string fileName = "testtsr.txt";
            string textToAdd = "Example text in file";
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.CreateNew);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(textToAdd);
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }*/

            /* using (var writer = new StreamWriter("path\\to\\file.csv"))
              using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
             {
                 csv.WriteRecords("Big Corp");
                 writer.Flush();
             }   */
        }
        private void SaveAndViewFile()
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Set the default application version as Excel 2013.
                excelEngine.Excel.DefaultVersion = ExcelVersion.Excel2016;

                //Create a workbook with a worksheet
                IWorkbook workbook = excelEngine.Excel.Workbooks.Create(1);

                //Access first worksheet from the workbook instance.
                IWorksheet worksheet = workbook.Worksheets[0];

                //Adding text to a cell
                worksheet.Range["A1"].Text = "Hello World";

                //Save the workbook to stream in xlsx format. 
                MemoryStream stream = new MemoryStream();
                workbook.SaveAs(stream);
                
                workbook.Close();

                //Save the stream as a file in the device and invoke it for viewing
                DependencyService.Get<ISave>().SaveAndView("TSR.xlsx", stream);
                //DependencyService.Get<ISave>().SaveText("TSR.xlsx", "application/msexcel");
            }

        }

        /*private async void File(object sender, EventArgs e)
        {


            var file = await CrossFilePicker.Current.PickFile();

            if (file != null)
            {
                fileLabel.Text = filepath;
            }
        }*/

        /*private void SendEmail()
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
            attachment = new Attachment("/TSR.xlsx ");
            ///data/user/0/com.companyname.tsr/files/TSR/TSR.xlsx

            //attachment = new Attachment();
            mail.Attachments.Add(attachment);
            smtpServer.Credentials = new NetworkCredential("fanymamto@gmail.com", "Orlann27");

            smtpServer.UseDefaultCredentials = false;
            smtpServer.EnableSsl = true;
            smtpServer.Send(mail);

        }*/

        async void endProcess_Clicked(object sender, EventArgs e)
        {
            fiche.calculerResultat();

            //Create an instance of ExcelEngine.
           // this.SaveAndViewFile();
            this.SaveFile();

            //this.SendEmail();

            await this.Navigation.PushAsync(new ThanksPage());
        }
    }
}