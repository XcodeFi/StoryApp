using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StoryApp.Extentions
{
    public static class StringExtensions
    {
        public static string CapitalizeForAndroid(this string str)
        {
            return Device.OS == TargetPlatform.Android ? str.ToUpper() : str;
        }
    }
}
