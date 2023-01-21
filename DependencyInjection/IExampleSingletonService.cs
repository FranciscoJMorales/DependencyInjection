using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection;

public interface IExampleSingletonService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
}
