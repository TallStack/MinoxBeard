using Autofac;
using CommonServiceLocator;
using MinoxBeard.Services;
using MinoxBeard.ViewModels;
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
            Device.SetFlags(new[] { "Expander_Experimental" });
            ContainerBuilder _builder = new ContainerBuilder();
            _builder.RegisterInstance(new RecordViewModel()).SingleInstance();
            var container = _builder.Build();

            var autoFacLocator = new Autofac.Extras.CommonServiceLocator.AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => autoFacLocator);
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
