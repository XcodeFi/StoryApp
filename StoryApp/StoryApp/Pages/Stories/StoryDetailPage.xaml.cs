using StoryApp.Pages.Base;
using StoryApp.ViewModels.Stories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryApp.Pages.Stories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoryDetailPage : StoryDetailPageXaml
    {
        public StoryDetailPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
    public abstract class StoryDetailPageXaml : ModelBoundContentPage<StoryDetailViewModel> { }
}