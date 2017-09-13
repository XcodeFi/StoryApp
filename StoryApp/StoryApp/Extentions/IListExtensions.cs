using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryApp.Extentions
{
    public static class IListExtensions
    {
        public static void AddRange<T>(this IList<T> collection, IEnumerable<T> items)
        {
            foreach (var i in items)
            {
                collection.Add(i);
            }
        }

        public static ObservableCollection<T> ToObservableCollection<T>(this IList<T> items)
        {
            var result = new ObservableCollection<T>();
            result.AddRange(items);
            return result;
        }
    }
}