using StoryApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {

        RootPage root;
        List<HomeMenuItem> menuItems;
        public MenuPage(RootPage root)
        {
            InitializeComponent();
            this.root = root;

            BindingContext = new BaseViewModel(Navigation)
            {
                Title = "XamarinCRM",
                Subtitle = "XamarinCRM",
                Icon = "icon.png"
            };

            LstMenu.ItemsSource = menuItems = new List<HomeMenuItem>
                {
                    new HomeMenuItem { Title = "Tra từ mới", MenuType = MenuType.NewWords, Icon ="search.png" },
                    new HomeMenuItem { Title = "Truyện chêm", MenuType = MenuType.Stories, Icon = "bookshell.png" },
                    new HomeMenuItem { Title = "Thông tin PM", MenuType = MenuType.About, Icon = "about.png" },

                };

            LstMenu.SelectedItem = menuItems[0];

            LstMenu.ItemSelected += async (sender, e) =>
            {
                if (LstMenu.SelectedItem == null)
                    return;

                await this.root.NavigateAsync(((HomeMenuItem)e.SelectedItem).MenuType);
            };
        }
    }
}
