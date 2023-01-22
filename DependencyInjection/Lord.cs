namespace DependencyInjection;

internal sealed class Lord : IClass
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    string IReportServiceLifetime.Name { get; } = "Lord";
    private readonly IWeapon _weapon;

    public Lord(IWeapon weapon)
    {
        _weapon = weapon;
    }

    public void ClassInfo()
    {
        Console.WriteLine("This class wields sword, and its outfit and attack animations are unique. Can promote into a Great Lord with a Master Seal.");
        Console.WriteLine($"Preferred weapon: {_weapon.Name}");
        Console.WriteLine($"{_weapon.Name}: {_weapon.Description}");
    }
}
