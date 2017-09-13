using StoryApp.Pages.Base;
using StoryApp.ViewModels.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryApp.Pages.NewWords
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WordDetailPage : WordDetailPageXaml
    {
        public WordDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
    public abstract class WordDetailPageXaml : ModelBoundContentPage<WordViewModel> { }
}