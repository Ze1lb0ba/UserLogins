using System;

namespace SecondHomevork
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string secondName, int age, string[] petnames, string[] favColours) user;
            user = UserInfo();

        }

        public static (string name, string secondName, int age, string[] petnames, string[] favColours) UserInfo()
        {
            (string n, string s, int a, string[] p, string[] f) user;
            Console.WriteLine("Введите имя");
            user.n = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            user.s = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string intent = Console.ReadLine();
            user.a = ChekerInt(intent);
        }

        public static int ChekerInt(string intEnt)
        {

        }
    }
}