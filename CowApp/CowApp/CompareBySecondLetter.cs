namespace CowApp;

public class CompareBySecondLetter:IComparer<Cow>
{
    public int Compare(Cow? x, Cow? y)
    {
        char secondLetterX = x.Name[1];
        char secondLetterY = y.Name[1];
        
        if (ReferenceEquals(x, y)) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return secondLetterX.CompareTo(secondLetterY);
    }
}