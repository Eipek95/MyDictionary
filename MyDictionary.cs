using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectDictionary
{
    public class MyDictionary<T,K>
    {
        KeyValuePair<T, K>[] items;
        KeyValuePair<T, K>[] tempItems;
        public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }
        public void Add(T key, K value)
        {
            tempItems = items;
            items = new KeyValuePair<T, K>[items.Length + 1];

            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }

            items[items.Length - 1] = new KeyValuePair<T, K>(key, value);
        }
        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Value} : {item.Key}");
            }
        }
        public int Count
        {
            get { return items.Length; }
        }
    }
}
