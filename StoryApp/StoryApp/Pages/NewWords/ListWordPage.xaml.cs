using StoryApp.Models;
using StoryApp.Pages.Base;
using StoryApp.Services;
using StoryApp.ViewModels.Words;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryApp.Pages.NewWords
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListWordPage : ListWordPageXaml
    {
        public ListWordPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (ViewModel.IsInitialized)
                return;

            ViewModel.LoadWordsCommand.Execute(null);
            ViewModel.IsInitialized = true;
        }
        async void WordItemTapped(object sender, ItemTappedEventArgs e)
        {
            Word _word = ((Word)e.Item);
            await Navigation.PushAsync(new WordDetailPage() { BindingContext = new WordViewModel(_word) { Navigation = ViewModel.Navigation } });
        }
    }

    public abstract class ListWordPageXaml : ModelBoundContentPage<ListWordViewModel> { }
}