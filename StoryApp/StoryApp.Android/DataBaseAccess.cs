using System;
using System.IO;
using Xamarin.Forms;
using StoryApp.Droid;
using SQLite;

[assembly: Dependency(typeof(Database_Android))]
namespace StoryApp.Droid
{
    public class Database_Android : IDatabaseAccess
    {
        public Database_Android() { }

        public string GetLocalFilePath(string filename)
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentsPath, filename);
            return path;
        }
    }
}
