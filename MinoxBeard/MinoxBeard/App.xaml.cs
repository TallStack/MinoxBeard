using Autofac;
using MinoxBeard.Services;
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
            DependencyService.Register<FaqDataStore>();

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
