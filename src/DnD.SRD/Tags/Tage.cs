namespace DnD.SRD.Tags;

public partial class Tage : IEquatable<Tage>
{
    private readonly string _id;

    protected Tage(string id)
    {
        _id = id;
    }

    public override int GetHashCode()
    {
        return _id.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Tage?)obj);
    }

    public bool Equals(Tage? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _id == other._id;
    }

    public static bool operator !=(Tage? left, Tage? right)
    {
        return !(left == right);
    }

    public static bool operator ==(Tage? left, Tage? right)
    {
        return ((object?)left == null && (object?)right == null) || (left != null && left.Equals(right));
    }
}
