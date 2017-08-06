using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
namespace Elog
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new HomePage());
            /*var tabContainer = new TabbedPage();
            tabContainer.Children.Add(new Page1("ggg"));
            //tabContainer.Children.Add(new ContentPage() { Title = "Klingons" });
            //tabContainer.Children.Add(new ContentPage() { Title = "Vulcans" });
            Parent = tabContainer;
            */
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
