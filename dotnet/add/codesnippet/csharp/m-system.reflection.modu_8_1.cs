using System;
using System.Reflection;

namespace ReflectionModule_Examples
{
    class MyMainClass
    {
        static void Main()
        {
            Module[] moduleArray;
            
            moduleArray = typeof(MyMainClass).Assembly.GetModules(false);
            
            //In a simple project with only one module, the module at index
            // 0 will be the module containing this class.
            Module myModule = moduleArray[0];

            Type myType;
            myType = myModule.GetType("ReflectionModule_Examples.MyMainClass", false, false);
            Console.WriteLine("Got type: {0}", myType.ToString());
        }
    }
}