namespace _10_Collections
{
    public interface IAsset
    {
        int Id {get;}

        double GetValue();
        string GetSymbol();
    }
}