using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectible
{
    public class MyCollectible : IEnumerable
    {
        public List<Pair> _items = new List<Pair>();
        public List<string> keys = new List<string>();
        public List<int> values = new List<int>();

        public int this[string key]
        {
            get { return values[keys.IndexOf(key)]; }
            set { values[keys.IndexOf(key)] = value; }
        }
        
        public void Add(string key, int value)
        {
            keys.Add(key);
            values.Add(value);
            _items.Add(new Pair(key, value));
        }
        public void Remove(string key)
        {
            values.Remove(values[keys.IndexOf(key)]);
            keys.Remove(key);
        }
        public IEnumerator GetEnumerator()
        {
            return new _Enumerator(_items);
        }

        public class _Enumerator:IEnumerator
        {
            private int index = 0;
            private List<Pair> _items;
            public _Enumerator(List<Pair> items)
            {
                _items = items;
            }
            public object Current
            {
                get
                {
                    return _items[index++];
                }
            }
            public bool MoveNext()
            {
                return _items.Count > index;
            }
            public void Reset()
            {
                index = -1;
            }
        }
        


    }
}
