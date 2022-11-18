using DnD.SRD.Abilities;
using DnD.SRD.Classes;
using DnD.SRD.Races;

namespace DnD.SRD.Characters;

public sealed class Character
{
    public HitPoints HitPoints { get; private set; }
    public Ability CharacterAbility { get; }
    public Race Race { get; }
    public BaseClass Class { get; }
    public Ability Ability => CharacterAbility + Race.Ability;

    public Character(
        Ability characterAbility,
        Race race,
        BaseClass @class)
    {
        CharacterAbility = characterAbility;
        Race = race;
        Class = @class;
        HitPoints = new HitPoints(Ability, Class);
    }
}