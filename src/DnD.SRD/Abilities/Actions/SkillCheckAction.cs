using DnD.SRD.Actions;
using DnD.SRD.Tags;

namespace DnD.SRD.Abilities.Actions;

public record SkillCheckAction : BaseAction
{
    public SkillCheckAction(
        SkillType skillType,
        IReadOnlyCollection<Tage> tags)
        : base(tags)
    {
        SkillType = skillType;
    }

    public SkillType SkillType { get; }
}
