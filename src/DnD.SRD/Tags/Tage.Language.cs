namespace DnD.SRD.Tags;

public partial class Tage
{
    public static class Language
    {
        public static Tage Common { get; } = new("common");
        public static Tage Dwarvish { get; } = new("dwarvish");
    }
}
