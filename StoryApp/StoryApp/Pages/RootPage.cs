using StoryApp.Pages.About;
using StoryApp.Pages.NewWords;
using StoryApp.Pages.Stories;
using StoryApp.Statics;
using StoryApp.ViewModels;
using StoryApp.ViewModels.Stories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using StoryApp.ViewModels.Words;

namespace StoryApp.Pages
{
    public class RootPage : MasterDetailPage
    {
        Dictionary<MenuType, NavigationPage> Pages { get; set; }
        public RootPage()
        {
            Pages = new Dictionary<MenuType, NavigationPage>();
            
            BindingContext = new BaseViewModel(Navigation)
            {
                Title = "StoryApp",
                Icon = "bookshell.png"
            };

            Master = new MenuPage(this);

            //setup home page
            NavigateAsync(MenuType.NewWords);
        }

        void SetDetailIfNull(Page page)
        {
            if (Detail == null && page != null)
                Detail = page;
        }
        public async Task NavigateAsync(MenuType id)
        {
            Page newPage;
            if (!Pages.ContainsKey(id))
            {
                switch (id)
                {

                    case MenuType.NewWords:
                        var page = new StoryAppNavigationPage(new ListWordPage
                        {
                            BindingContext = new ListWordViewModel() { Navigation = this.Navigation },
                            Title = "Tra từ mới",
                            Icon = new FileImageSource { File = "search.png" }
                        });
                        SetDetailIfNull(page);
                        Pages.Add(id, page);
                        break;
                    case MenuType.Stories:
                        page = new StoryAppNavigationPage(new ListStoryPage
                        {
                            BindingContext = new ListStoryViewModel() { Navigation = this.Navigation },
                            Title = "Truyện chêm",
                            Icon = new FileImageSource { File = "bookshell.png" }
                        });
                        SetDetailIfNull(page);
                        Pages.Add(id, page);
                        break;
                    case MenuType.About:
                        page = new StoryAppNavigationPage(new AboutItemListPage
                        {
                            Title = "Thông tin PM",
                            Icon = new FileImageSource { File = "about.png" }
                        });
                        SetDetailIfNull(page);
                        Pages.Add(id, page);
                        break;
                }
            }
            newPage = Pages[id];
            if (newPage == null)
                return;

            //pop to root for Windows Phone
            if (Detail != null && Device.OS == TargetPlatform.WinPhone)
            {
                await Detail.Navigation.PopToRootAsync();
            }

            Detail = newPage;

            if (Device.Idiom != TargetIdiom.Tablet)
                IsPresented = false;
        }
    }

    public class StoryAppNavigationPage : NavigationPage
    {
        public StoryAppNavigationPage(Page root)
            : base(root)
        {
            Init();
        }

        public StoryAppNavigationPage()
        {
            Init();
        }

        void Init()
        {

            BarBackgroundColor = Palette._001;
            BarTextColor = Color.White;
        }
    }
    public enum MenuType
    {
        Sales,
        Customers,
        Products,
        About,
        NewWords,
        Stories
    }

    public class HomeMenuItem
    {
        public HomeMenuItem()
        {
            MenuType = MenuType.About;
        }

        public string Icon { get; set; }

        public MenuType MenuType { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public int Id { get; set; }
    }
}