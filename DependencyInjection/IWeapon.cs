using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection;

public interface IWeapon : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
    string Description { get; }
}
