using Plugin.Connectivity;
using SQLite;
using StoryApp.Localization;
using StoryApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StoryApp
{
    public partial class App : Application
    {

        static Application _app;

        public static Application CurrentApp
        {
            get { return _app; }
        }

        static SQLiteAsyncConnection dbAsyncConnection;
        public static SQLiteAsyncConnection DbConnectionAsync
        {
            get
            {
                if (dbAsyncConnection == null)
                {
                    dbAsyncConnection = new SQLiteAsyncConnection(DependencyService.Get<IDatabaseAccess>().GetLocalFilePath("TodoSQLite.db3"));
                }
                return dbAsyncConnection;
            }
        }

        static SQLiteConnection dbConnection;
        public static SQLiteConnection DbConnection
        {
            get
            {
                if (dbConnection == null)
                {
                    dbConnection = new SQLiteConnection(DependencyService.Get<IDatabaseAccess>().GetLocalFilePath("TodoSQLite.db3"));
                }
                return dbConnection;
            }
        }
        public App()
        {
            InitializeComponent();
            _app = this;

            MainPage = new RootPage();

        }

        public static void GoToRoot()
        {
            if (Device.OS == TargetPlatform.iOS)
            {
                //CurrentApp.MainPage = new RootTabPage();
            }
            else
            {
                CurrentApp.MainPage = new RootPage();
            }
        }


        public static async Task ExecuteIfConnected(Func<Task> actionToExecuteIfConnected)
        {
            if (IsConnected)
            {
                await actionToExecuteIfConnected();
            }
            else
            {
                await ShowNetworkConnectionAlert();
            }
        }

        static async Task ShowNetworkConnectionAlert()
        {
            await CurrentApp.MainPage.DisplayAlert(
                TextResources.NetworkConnection_Alert_Title,
                TextResources.NetworkConnection_Alert_Message,
                TextResources.NetworkConnection_Alert_Confirm);
        }

        public static bool IsConnected
        {
            get { return CrossConnectivity.Current.IsConnected; }
        }

        public static int AnimationSpeed = 250;


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
