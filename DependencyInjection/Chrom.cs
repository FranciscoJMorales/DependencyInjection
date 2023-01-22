namespace DependencyInjection;

internal sealed class Chrom : IWarrior
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    string IReportServiceLifetime.Name { get; } = "Chrom";

    private readonly IClass _class;

    public Chrom(IClass Class) {
        _class = Class;
    }

    public void DescribeWarrior()
    {
        Console.WriteLine("Chrom is the main protagonist of Fire Emblem Awakening. He is prince of the halidom of Ylisse.");
        Console.WriteLine($"His class is {_class.Name}");
        _class.ClassInfo();
    }
}
