using System;
using System.IO;
using Android.Content;
using Java.IO;
using Xamarin.Forms;
using System.Threading.Tasks;
using TSR.DAL;

[assembly: Dependency(typeof(SaveAndroid))]

class SaveAndroid: ISave
    {
    //Method to save document as a file in Android and view the saved document
    [Obsolete]
    public async Task SaveText(string filename, string text)
    {
        var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
        var filePath = Path.Combine(documentsPath, filename);
        System.IO.File.WriteAllText(filePath, text);
    }

    public async Task SaveAndView(string fileName, MemoryStream stream)
        {
            string root = null;
        //Get the root path in android device.
        /* if (Android.OS.Environment.IsExternalStorageEmulated)
         {
             root = Android.OS.Environment.ExternalStorageDirectory.ToString();
         }
         else*/
        string target = @"C:\Users\Fanelle\Documents\TSR\Test";

        root = target;

        /*if (!Directory.Exists(target))
        {            
            Directory.CreateDirectory(target);
        }*/


        //Environment.CurrentDirectory = target;
        // root = Directory.GetCurrentDirectory();

        //Create directory and file 
        //string path = @"D:\Python_Files\my_file.py";
        /*Java.IO.File file = null;
        using (file = File.Create(root)) ;*/

            Java.IO.File myDir = new Java.IO.File(root);
            myDir.Mkdir();

            Java.IO.File file = new Java.IO.File(myDir, fileName);

            //Remove if the file exists
            //if (file.Exists()) file.Delete();

            //Write the stream into the file
            FileOutputStream outs = new FileOutputStream(file);
            outs.Write(stream.ToArray());

            outs.Flush();
            outs.Close();

            //Invoke the created file for viewing
            /*if (file.Exists())
            {
                Android.Net.Uri path = Android.Net.Uri.FromFile(file);
                string extension = Android.Webkit.MimeTypeMap.GetFileExtensionFromUrl(Android.Net.Uri.FromFile(file).ToString());
                string mimeType = Android.Webkit.MimeTypeMap.Singleton.GetMimeTypeFromExtension(extension);
                Intent intent = new Intent(Intent.ActionView);
                intent.SetDataAndType(path, mimeType);
                Forms.Context.StartActivity(Intent.CreateChooser(intent, "Choose App"));
            }*/
        }
}
