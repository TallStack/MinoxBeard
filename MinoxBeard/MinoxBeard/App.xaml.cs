using Autofac;
using CommonServiceLocator;
using MinoxBeard.Helpers;
using MinoxBeard.Services;
using MinoxBeard.ViewModels;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinoxBeard
{
    public partial class App : Application
    {

        static SQLiteHelper db;
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Expander_Experimental" });
            ContainerBuilder _builder = new ContainerBuilder();
            _builder.RegisterInstance(new RecordViewModel()).SingleInstance();
            _builder.RegisterInstance(new AddRecordViewModel()).SingleInstance();
            _builder.RegisterInstance(new RoutineViewModel()).SingleInstance();
            _builder.RegisterInstance(new AddRoutineViewModel()).SingleInstance();
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

        public static SQLiteHelper SQLiteDb
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MinoxBeard.db3"));
                }
                return db;
            }
        }

    }
}
