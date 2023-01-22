using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection;

public interface IClass : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
    void ClassInfo();
}
