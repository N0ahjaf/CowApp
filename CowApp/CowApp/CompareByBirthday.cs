namespace CowApp;

public class CompareByBirthday:IComparer<Cow>
{
    public int Compare(Cow? x, Cow? y)
    {
        
        if (ReferenceEquals(x, y)) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Geburt.CompareTo(y.Geburt);
    }
}