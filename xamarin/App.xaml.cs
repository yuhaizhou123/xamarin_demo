using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Notes;
using xamarin.Data;
using System.IO;

namespace xamarin
{
    public partial class App : Application
    {
        static XamarinDataBase database;
        public static XamarinDataBase Database
        {
            get
            {
                if(database == null)
                {
                    database = new XamarinDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "XamarinData.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            //MainPage = new ListPage();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            //当你的应用程序启动时的处理
        }

        protected override void OnSleep()
        {
            //应用程序休眠时的句柄
        }

        protected override void OnResume()
        {
            //当你的应用程序恢复时处理
        }
    }
}
