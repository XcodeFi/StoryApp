using StoryApp.Models;
using StoryApp.Pages.Base;
using StoryApp.Services;
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
    public partial class ListStoryPage : ListStoryPageXaml
    {
        public ListStoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (ViewModel.IsInitialized)
                return;

            var repo = new StoryRepo();

            repo.Insert(new Story
            {
                Title = "story 1",
                Content = "content 1"
            });

            ViewModel.LoadStoriesCommand.Execute(null);
            ViewModel.IsInitialized = true;
        }
        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StoryAddNewPage()
            {
                BindingContext = new StoryDetailViewModel(new Story())
                {
                    Navigation = ViewModel.Navigation,
                    Title = "Thêm truyện mới",
                }
            });
        }

        async void StoryItemTapped(object sender, ItemTappedEventArgs e)
        {
            Story story = ((Story)e.Item);
            await Navigation.PushAsync(new StoryDetailPage() { BindingContext = new StoryDetailViewModel(story) { Navigation = ViewModel.Navigation } });
        }
    }

    public abstract class ListStoryPageXaml : ModelBoundContentPage<ListStoryViewModel> { }
}