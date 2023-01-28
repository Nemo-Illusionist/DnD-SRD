namespace DnD.SRD.Tags;

public partial class Tage
{
    public static class Script
    {
        public static Tage Common { get; } = new("script_common");
        public static Tage Dwarvish { get; } = new("script_dwarvish");
        public static Tage Elvish { get; } = new("script_elvish");
        public static Tage Infernal { get; } = new("script_infernal");
        public static Tage Celestial { get; } = new("script_celestial");
        public static Tage Draconic { get; } = new("script_draconic");
    }
}
