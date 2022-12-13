using DnD.SRD.Abilities;

namespace DnD.SRD.Actions;

public interface ISkillCheckAction : IAction
{
    public SkillType SkillType { get; set; }
}
