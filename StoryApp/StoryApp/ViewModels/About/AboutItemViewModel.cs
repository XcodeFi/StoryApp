using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryApp.ViewModels.About
{
    public class AboutItemViewModel : BaseViewModel
    {
        public string Description { get; set; }
        public string Uri { get; set; }

        public bool UriIsPresent
        {
            get
            {
                return !String.IsNullOrWhiteSpace(Uri);
            }
        }
    }
}

