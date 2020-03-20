using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using my_notes_app.Services;
using my_notes_app.Views;

namespace my_notes_app
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
