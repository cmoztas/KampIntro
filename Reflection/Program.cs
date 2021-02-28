using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(DortIslem);
            var instance = Activator.CreateInstance(type, 6, 7);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("------------------------");

            Console.WriteLine($"Instance Name: {instance.GetType().Name}");
            Console.WriteLine($"Instance Fullname: {instance.GetType().FullName}");


            var metodlar = type.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine($"Method adı: {info.Name}");

                foreach (var parameter in info.GetParameters())
                {
                    Console.WriteLine($"Parametre: {parameter.Name}");
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine($"Attribute: {attribute.GetType().Name}");
                }
            }
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem()
        {

        }

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}
