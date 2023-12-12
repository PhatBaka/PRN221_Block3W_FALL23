using Microsoft.Extensions.DependencyInjection;
using Repositories.Interfaces;
using Repositories;
using Services.Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Assignment1_WPF.Views;

namespace Assignment1_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            // Config for DI
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var login = serviceProvider.GetService<Login>();
            login.Show();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<Login>();
            // CATEGORY

            // ACCOUNT
            services.AddSingleton<AccountRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountService, AccountService>();

            // FLOWER BOUQUET

            // ORDER DETAIL

            // ORDER

            // SUPPLIER

            // ROLE

            // IMAGE
            services.AddSingleton<ImageRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<IImageService, ImageService>();
        }
    }
}
