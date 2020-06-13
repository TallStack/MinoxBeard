using Autofac;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinoxBeard
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ContainerBuilder _builder = new ContainerBuilder();

            MainPage = new AppShell();
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
