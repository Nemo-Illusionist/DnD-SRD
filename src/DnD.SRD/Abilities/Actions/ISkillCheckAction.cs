using DnD.SRD.Actions;

namespace DnD.SRD.Abilities.Actions;

public interface ISkillCheckAction : IAction
{
    public SkillType SkillType { get; set; }
}
