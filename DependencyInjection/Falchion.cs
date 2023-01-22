namespace DependencyInjection;

internal sealed class Falchion : IWeapon
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    string IReportServiceLifetime.Name { get; } = "Falchion";
    string IWeapon.Description { get; } = "Mt: 5. Wieldable only by Chrom; effective against dragon units.";
}
