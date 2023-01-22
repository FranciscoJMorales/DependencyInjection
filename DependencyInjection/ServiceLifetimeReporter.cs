namespace DependencyInjection;

internal sealed class ServiceLifetimeReporter
{
    private readonly IWarrior _warrior;

    public ServiceLifetimeReporter(IWarrior warrior) => (_warrior) = (warrior);

    public void ReportServiceLifetimeDetails(string lifetimeDetails)
    {
        Console.WriteLine(lifetimeDetails);

        LogService(_warrior, $"Descripción de personaje: { _warrior.Name }");
        _warrior.DescribeWarrior();
    }

    private static void LogService<T>(T service, string message)
        where T : IReportServiceLifetime =>
        Console.WriteLine(
            $"    {typeof(T).Name}: {service.Id} ({message})");
}
