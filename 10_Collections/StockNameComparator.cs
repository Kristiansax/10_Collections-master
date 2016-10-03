
using System.Collections.Generic;

namespace _10_Collections
{
    public class StockNameComparator : IComparer<IAsset>
    {
        public int Compare(IAsset x, IAsset y)
        {
            return x.GetSymbol().CompareTo(y.GetSymbol());           
        }

    }
}