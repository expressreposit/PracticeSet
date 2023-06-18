using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.IO;
namespace ImpPractical
{
    class AppDomainConcept
    {
        static void Main1(string[] args)
        {
            var perm = new PermissionSet(PermissionState.None);

            //perm.AddPermission(
            //    new secur(SecurityPermissionFlag.Execution));
            //perm.AddPermission(new FileIO)

            //App Domain which secure does not allow to touch my c:\ drive
            ThirdPartyDll third = new ThirdPartyDll();
            
            AppDomain securedDomain = AppDomain.CreateDomain("secured Domain");
            Type thirdparty = typeof(ThirdPartyDll);
            securedDomain.CreateInstanceAndUnwrap(thirdparty.Assembly.FullName, thirdparty.FullName);
            AppDomain.Unload(securedDomain);
            // In to the current app domain
            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();
            Console.ReadLine();
        }
    }
    [Serializable]
    class ThirdPartyDll
    {
        public ThirdPartyDll()
        {
            Console.WriteLine("Third party loaded");
            System.IO.File.Create(@"c:\x.txt");
        }
        ~ThirdPartyDll()
        {
            Console.WriteLine("Third party unloaded");
        }
    }
    class Class1
    {

    }
    class Class2
    {

    }
}
