using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pp_Singleton
{
    class Singleton
    {
        public int Count;
        private Singleton()
        {
            Count = 0;
        }
        private static Singleton _instance;
        public static Singleton Getinstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        public void someBusinessLogic()
        {
            Count++;
            Console.WriteLine($"Количество обращений = {Count}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Getinstance();
            Singleton s2 = Singleton.Getinstance();
            if (s1 == s2)
            {
                Console.WriteLine("Singleton works.");
            }
            else
            {
                Console.WriteLine("Singleton failed.");
            }
            s2.someBusinessLogic();
            s2.someBusinessLogic();
            s1.someBusinessLogic();
            Console.ReadLine();

        }
    }
}
