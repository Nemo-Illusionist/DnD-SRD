namespace DnD.SRD.Equipments.Armors;

public sealed record Armor
{
    public Armor(ArmorType type)
    {
        Type = type;
    }

    public ArmorType Type { get; private init; }
}
