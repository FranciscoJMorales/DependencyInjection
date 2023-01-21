using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection;

public interface IExampleScopedService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
}
