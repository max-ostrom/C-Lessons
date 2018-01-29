using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public sealed class GenericsDictionary<TKey, TValue> where TKey : struct
    {
        public void Add(TKey key, TValue value)
        {

        }
        public TValue this[TKey key]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
