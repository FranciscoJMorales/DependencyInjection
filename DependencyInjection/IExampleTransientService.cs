using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection;

public interface IExampleTransientService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
}
