using System;
using System.Runtime.InteropServices.ObjectiveC;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Danil";
            //int age = 18;
            //string city = "Volgograd";
            //Console.WriteLine("ваше имя {0}, ваш возраст {1}, ваш город {2}", name, age, city)
            //byte bit1 = 1;
            //byte bit2 = 255;
            //byte bit3 = 464643125;
            //int number = 121212;
            //Int128 number5 = 12345678;

            //System.Int32 number6 = 45727;

            //bool alive = true;
            //bool isdead = false;

            //float floating1 = 3.14f;
            //double yNumber = 3.4353;
            //decimal bb = 4.2542675m;

            //string name = "Danya";
            //char symbol = 'A';

            //object obl = 3.3;
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

            //Console.WriteLine("Введите Ваше имя: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Ваше имя -- {name}");
            //Console.WriteLine("youe age: ");
            //int age = int.Parse
            //    ( Console.ReadLine() );
            //Console.WriteLine($"your age is {age} y.o.");
            //var number = 10;
            //byte bit1 = 1;
            //byte bit2 = 100;
            //sbyte bit3 = -101;
            //sbyte bit4 = 102;
            //short n1 = 1;
            //short n2 = 102;
            //ushort n3 = 1;
            //ushort n4 = 102;
            //int integer1 = 10;
            //int integer2 = 0b101;
            //uint integer3 = 10;
            //int integer4 = 0b101;
            //long number1 = -10;
            //long number2 = 0b101;
            //ulong number3 = 10;
            //ulong number4 = 0b101;
            //bool alive = true;
            //bool isDead = false;
            //float floating1 = 3.14F;
            //float floating2 = 30.6f;
            //double yNumber1 = 3.14;
            //double yNumber2 = 36.6;
            //decimal dNumber1 = 4.5m;
            //decimal dNumber2 = 23.56M;
            //char s = 'A';
            //char d = ' ';
            //string hello = "hello";
            //string word = "world";
            //object ob1 = 22;
            //object ob2 = 3.14;
            //object ob3 = "hello code";
            //string name = null;
            //Console.WriteLine(name);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(double.MinValue);
            //string numStr = "123";
            //string nullStr = null;
            //int number1 = Convert.ToInt32(numStr);
            //int number2 = int.Parse(nullStr);
            //int metr1 = 1;
            //System.Int32 metr2 = 1;
            //var number = 10;
            //var symbol = 'c';
            //var greeting = "Hello";
            //string hello = "Hello world";
            //Console.WriteLine(hello);
            //Console.WriteLine("Я изучаю C#");
            //Console.WriteLine("Goodbye World...");
            //Console.WriteLine(36.6);

            //Самостоятельные задания
            //1
            string FavGame = "Genshin Impact";
            int FavNumber = 23;
            char FavChar = 'M';
            Console.WriteLine($"Моя любимая игра - {FavGame}, мое любимое число - {FavNumber}, значение число пи - {Math.PI}, моя любимая буква алфавита - {FavChar}.");
            //2
            Console.WriteLine('i');
            Console.WriteLine("need");
            Console.WriteLine("more");
            Console.WriteLine("power!");
            //3
            Console.WriteLine("Hello there");
            //4
            int Monitor = 5000;
            int Sistemnik = 35000;
            int Klaviatura = 2000;
            int Mouse = 500;
            Console.WriteLine((Monitor + Sistemnik + Klaviatura + Mouse) * 3);
            //5
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(3 * (a + b) ^ 3 + 275 * b ^ 2 - 127 * a - 41);
            //6
            Console.WriteLine("name?");
            string name = (Console.ReadLine());
            Console.WriteLine("age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Привет, {name}!");
            Console.WriteLine($"Сейчас тебе {age} лет.");
            Console.WriteLine($"В следующем году тебе будет {age + 1}");
            //7
            Console.WriteLine("name?");
            string namee = (Console.ReadLine());
            Console.WriteLine("age?");
            int agee = int.Parse(Console.ReadLine());
            Console.WriteLine("city?");
            string city = (Console.ReadLine());
            Console.WriteLine($"Привет, {namee}! Тебе {agee} лет и ты живёшь в городе {city}.");
            //8
            Console.WriteLine("temperature?");
            int temperature = int.Parse(Console.ReadLine());
            Console.WriteLine(((temperature * 9 / 5) + 32), "°F");
        }
    }
}
