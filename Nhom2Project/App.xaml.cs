using System;
using Nhom2Project.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nhom2Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new LoginView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
