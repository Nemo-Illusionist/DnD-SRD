using DnD.SRD.Abilities;
using DnD.SRD.Classes;

namespace DnD.SRD.Characters;

public sealed record HitPoints
{
    public int Full { get; private set; }
    public int Current { get; private set; }
    public int Temporary { get; private set; }

    public HitPoints(Ability ability, BaseClass @class)
    {
        // todo: guard

        Full = Current = ability.Constitution.Modifier; // todo: add class
        Temporary = 0;
    }

    public void AddHitPoints(int value)
    {
        // todo: guard value >= 0

        if (Current + value >= Full)
        {
            Current = Full;
        }
        else
        {
            Current += value;
        }
    }

    public CharacterStatus Damage(int value)
    {
        // todo: guard value >= 0

        if (Temporary != 0)
        {
            if (value >= Temporary)
            {
                value -= Temporary;
                Temporary = 0;
            }
            else
            {
                Temporary -= value;
                value = 0;
            }
        }

        if (value >= Current + Full)
        {
            Current = -Full;
            return CharacterStatus.Dead;
        }

        Current -= value;
        return Current <= 0 ? CharacterStatus.Unconscious : CharacterStatus.None;
    }

    public void SetTemporary(int temporary, bool ifMore)
    {
        // todo: guard temporary > 0

        Temporary = ifMore && temporary > Temporary ? temporary : Temporary;
    }
}
