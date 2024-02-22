using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimerPro1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TimerProPage();
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
