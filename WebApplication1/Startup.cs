using Hangfire;

namespace WebApplication1
{
    public static class ServiceCollectionHangfireExtension
    {
        public static IServiceCollection ConfigureHangFire(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddHangfire(x => x.UseSqlServerStorage("<connection string>"));
            serviceCollection.AddHangfireServer();

            RecurringJob.AddOrUpdate(
                "anual_report",
                () => 
                    Console.WriteLine("Recurring!"),
                "0 0 1 1 *");

            return serviceCollection;
        }
    }
}
