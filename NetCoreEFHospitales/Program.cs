using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreEFHospitales.Data;
using NetCoreEFHospitales.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreEFHospitales
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            string cnn = configuration.GetConnectionString("HospitalSQLServer");

            var provider = new ServiceCollection()
                .AddTransient<RepositoryHospital>()
                .AddDbContext<HospitalContext>
                (options => options.UseSqlServer(cnn))
                .AddSingleton<Form1>()
                .AddTransient<RepositoryDoctores>()
                .AddSingleton<FormDoctores>()
                .AddSingleton<FormDoctoresEspecialidad>()
                .BuildServiceProvider();

            var form = provider.GetService<FormDoctoresEspecialidad>();
            Application.Run(form);
        }
    }
}
