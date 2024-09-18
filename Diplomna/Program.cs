using Diplomna.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Diplomna
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

            var optionsBuilder = new DbContextOptionsBuilder<DBDataAccess>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using var dbContext = new DBDataAccess(optionsBuilder.Options);
            using FrmLogin loginForm = new(dbContext, configuration);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmAirportMain(dbContext, configuration));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}