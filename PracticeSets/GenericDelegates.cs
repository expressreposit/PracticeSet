using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeSets
{
    //Mapped Delegates static and instance methods
    delegate void MuDeligate();
    public class MyMainClass
    {
        static public void Main()
        {
            Console.WriteLine("-----------------------------------------------------Mapped Delegates static method and instance methods");
            GenericDelegates genericDelegatesObj = new GenericDelegates();
            //Deligate Map to the Instance Method
            MuDeligate muDeligateObj = new MuDeligate(genericDelegatesObj.InstanceMethods);
            muDeligateObj();

            //Deligate Map to the Static Method 
            //Static Methods call from Deligate using ClassName.MethodName
            muDeligateObj = new MuDeligate(GenericDelegates.StaticMethod);
            muDeligateObj();
            Console.Read();
        }
    }
    class GenericDelegates
    {
        public void InstanceMethods()
        {
            Console.WriteLine("Instance Methods call from Deligate");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Static Methods call from Deligate");
        }
    }
    
}
