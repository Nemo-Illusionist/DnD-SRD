namespace DnD.SRD.Tags;

public class EnvironmentTage : Tage
{
    protected EnvironmentTage(string id) : base(id)
    {
    }

    public static EnvironmentTage Stonework { get; } = new("stonework");
}
