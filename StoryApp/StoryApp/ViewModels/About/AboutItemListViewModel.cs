using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryApp.ViewModels.About
{
    public class AboutItemListViewModel : BaseViewModel
    {
        public List<AboutItemViewModel> Items { get; private set; }

        public string Overview { get; private set; }

        public string ListHeading { get; private set; }

        public AboutItemListViewModel()
        {
            Items = new List<AboutItemViewModel>()
            {
                new AboutItemViewModel()
                {
                    Title = "Xamarin Platform",
                    Uri = "https://xamarin.com/platform"
                },

                new AboutItemViewModel()
                {
                    Title = "Xamarin.Forms",
                    Uri = "https://xamarin.com/forms"
                },

                new AboutItemViewModel()
                {
                    Title = "HockeyApp",
                    Uri = "http://www.hockeyapp.net"
                },

                new AboutItemViewModel()
                {
                    Title = "Syncfusion Essentials for Xamarin.Forms",
                    Uri = "http://www.syncfusion.com/products/xamarin"
                },

                new AboutItemViewModel()
                {
                    Title = "Azure App Services Mobile",
                    Uri = "https://azure.microsoft.com/en-us/services/app-service/"
                },

                new AboutItemViewModel()
                {
                    Title = "Microsoft ADAL (Active Directory Authentication Library)",
                    Uri = "https://github.com/Azure/azure-content/blob/master/articles/active-directory/active-directory-authentication-libraries.md"
                },

                new AboutItemViewModel()
                {
                    Title = "Plugins for Xamarin (community-contributed)",
                    Uri = "https://github.com/xamarin/plugins"
                },

                new AboutItemViewModel()
                {
                    Title = "Newtonsoft Json.NET",
                    Uri = "http://www.newtonsoft.com/json"
                },
            };

            Overview =
                "Xamarin CRM is a demo app whose imagined purpose is to serve the mobile workforce of a " +
            "fictitious company that sells 3D printer hardware and supplies. The app empowers salespeople " +
            "to track their sales performance, manage leads, view their contacts, manage orders, and " +
            "browse a product catalog.";

            ListHeading =
                "The app is built with Xamarin Platform and Xamarin.Forms, and takes advantage of " +
                "several other supporting technologies:";
        }
    }
}

