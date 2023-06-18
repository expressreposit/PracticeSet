using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeSets
{
    class GenericsType<T>
    { 
        public T _value;
        public GenericsType(T t)
        {
            this._value = t;
        }
        public void input()
        {
            Console.WriteLine(this._value);
        }
    }
}
