using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection;

public interface IWarrior : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
    void DescribeWarrior();
}
