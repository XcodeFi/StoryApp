using StoryApp.iOS;
using System;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(DataBaseAccess_iOS))]
namespace StoryApp.iOS
{
    public class DataBaseAccess_iOS:IDatabaseAccess
    {
        public DataBaseAccess_iOS()
        {
        }

        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }
    }
}