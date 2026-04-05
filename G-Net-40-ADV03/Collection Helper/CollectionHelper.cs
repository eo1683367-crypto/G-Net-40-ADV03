using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV03.Collection_Helper
{
    internal static class CollectionHelper
    {
        public static void PrintCollection<T>(string CollectionName, IEnumerable<T> items)
        {
            Console.WriteLine($"{CollectionName}: {string.Join(",", items)}");
        }
    }
}
