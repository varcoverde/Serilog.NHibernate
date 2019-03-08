using Serilog;
using Serilog.Events;

namespace Serilog.NHibernate
{
    public class SerialogNHibernateSqlLogger
    {
        public void Logger()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Warning()
                .MinimumLevel.Override("NHibernate.SQL", LogEventLevel.Debug)

                .Enrich.FromLogContext()
                .WriteTo.RollingFile("nhibernate-sql-{HalfHour}.log")
                .CreateLogger();
        }
    }
}
