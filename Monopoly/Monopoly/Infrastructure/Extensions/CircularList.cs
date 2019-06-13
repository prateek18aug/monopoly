using System.Collections.Generic;

namespace Monopoly.Infrastructure.Extensions
{
    public static class CircularList
    {
        public static T NextOrFirst<T>(this IList<T> list, int index)
        {
            return list[(index+1) % list.Count];
        }
    }
}
