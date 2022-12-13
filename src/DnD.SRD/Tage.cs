namespace DnD.SRD;

public record Tage(string Id)
{
    public static Tage Stonework { get; } = new("stonework");
}
