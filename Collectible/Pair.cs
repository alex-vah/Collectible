using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectible
{
    public class Pair
    {
        private string _key;
        private int _value;
        
        public Pair(string key, int value)
        {
            _key = key;
            _value = value;
        }
        public string Key
        {
            get { return _key; }
        }
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
