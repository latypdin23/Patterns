using System;
using TemplateMethod.Model;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowTemplateMethod();
        }
        static void ShowTemplateMethod()
        {
            // Создаем два вида пирога.
            var meatPie = new MeatPie();
            var applePie = new ApplePie();

            // Готовим мясной пирог.
            Console.WriteLine(meatPie);
            meatPie.Cook();
            Console.ReadLine();

            // Готовим яблочный пирог.
            Console.WriteLine(applePie);
            applePie.Cook();
            Console.ReadLine();
        }
    }
}
