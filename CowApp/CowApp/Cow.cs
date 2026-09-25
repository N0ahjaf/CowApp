namespace CowApp;

public class Cow:IEquatable<Cow>
{
    public string Name { get; set; }
    public string Colour { get;  set; }
    public int Age { get; set; }

    public bool Equals(Cow? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name && Colour == other.Colour && Age == other.Age;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Cow)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Colour, Age);
    }
}