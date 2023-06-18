using System;
using System.Collections.Generic;
using System.Text;

 /*
        Remark on Generic Type
        We use generic types to maximize the code reuse, increase the performance of a application and type safety. 
        Most common use of generics is to create collection classes just like ArrayList, Dictionary, Stack, Queue etc.
*/
namespace GenericsTypes
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
    public class CalculationClass<T>
    {
        public T _value1;
        public T _value2;
        public CalculationClass(T t1, T t2)
        {
            this._value1 = t1;
            this._value2 = t2;
        }
    }
}
