using System.Reflection;

namespace ReflectionDemo1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            Type t = a.GetType();
            Console.WriteLine(t);

            Type type = typeof(int);
            Console.WriteLine(type.Assembly);

            Add add = new Add();
            

            ConstructorInfo[] constructorInfos = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);

            foreach(ConstructorInfo constructorInfo in constructorInfos)
            {
            Console.WriteLine(constructorInfo);
            }

            MethodInfo[] methodInfos = t.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach(MethodInfo methodInfo in methodInfos)
            {
            Console.WriteLine(methodInfos);
            }
        
        }
    }
}