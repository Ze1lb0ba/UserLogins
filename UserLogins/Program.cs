using System;

namespace SecondHomevork
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string secondName, int age, string[] petnames, string[] favColours) user;
            user = UserInfo();
            Console.WriteLine("");
            Console.WriteLine(user.name);
            Console.WriteLine(user.secondName);
            Console.WriteLine(user.age);
            if (user.petnames.Length != 0) 
            {
                for (int i = 0; i < user.petnames.Length; i++)
                {
                    Console.WriteLine("Питомца под номером {0} зовут: {1}.", (i + 1), user.petnames[i]);
                }
            }
            Console.WriteLine("Ваши любимые цвета: " + user.favColours[0]);
            for (int i = 1; i < user.favColours.Length; i++)
            {
                Console.WriteLine(user.favColours[i]);
            }
        }

        public static (string, string, int, string[], string[]) UserInfo()
        {
            (string n, string s, int a, string[] p, string[] f) user;
            Console.WriteLine("Введите имя");
            user.n = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            user.s = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            string intent = Console.ReadLine();
            user.a = ChekerInt(intent);

            Console.WriteLine("Есть ли у вас домашние питомцы (да/нет)");
            string answer = Console.ReadLine();
            if (answer == "Да" || answer == "да")
            {
                Console.WriteLine("Введите количество питомцев");
                intent = Console.ReadLine();
                int petcount = ChekerInt(intent);
                user.p = new string[petcount];
                for (int i = 0; i < user.p.Length; i++)
                {
                    Console.WriteLine("Введите имя питомца под номером " + (i + 1));
                    user.p[i] = Console.ReadLine();
                }
            }
            else user.p = new string[0];

            Console.WriteLine("Введите количество количество любимых цветов");
            intent = Console.ReadLine();
            int colourCount = ChekerInt(intent);
            user.f = new string[colourCount];
            for(int i=0; i<user.f.Length; i++)
            {
                Console.WriteLine("Введите цвет под номером " + (i + 1));
                user.f[i] = Console.ReadLine();
            }
            return user;
        }

        public static int ChekerInt(string intEnt)
        {
            int znak;
            bool check = int.TryParse(intEnt, out znak);
            if(check == true && znak > 0)
            {
                return znak;
            }
            
            else
            {
                Console.WriteLine("Введенное число не корректно, попробуйте ещё раз.");
                intEnt = Console.ReadLine();
                ChekerInt(intEnt);
            }
            return znak;
        }
    }
}