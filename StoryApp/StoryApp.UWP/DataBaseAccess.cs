using Xamarin.Forms;
using StoryApp.UWP;
using Windows.Storage;
using System.IO;

[assembly: Dependency(typeof(DataBaseAccess))]
namespace StoryApp.UWP
{
    public class DataBaseAccess : IDatabaseAccess
    {
        public string GetLocalFilePath(string filename)
        {
            var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
            return path;
        }
    }
}
