using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public sealed class Nullable<T> where T : struct
    {
        private object _value;
        public Nullable()
        {

        }
        public Nullable(T value)
        {
            _value = value;
        }
        public bool HasValue
        {
            get { return _value != null; }
        }
        public T GetValueOrDefault
        {
            get
            {
                if (HasValue)
                    return (T)_value;
                else
                    return default(T);
            }
        }
    }
}
