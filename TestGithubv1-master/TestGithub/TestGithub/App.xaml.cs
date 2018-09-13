using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestGithub.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestGithub
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //test comment without source control
            //this comment after adding the project to source control
            MainPage = new MainPage();
        }

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
