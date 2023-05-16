using System;


namespace OOPCSH
{
    class Init
    {
        static void Main(string[] args)
        {
            int sw;
            Labs lb = new Labs();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Вариант 9");
                Console.Write("Выберите номер лабораторной работы 2-6, выход 0 - ");
                sw = Int32.Parse(Console.ReadLine());
                if (sw == 0)
                    break;
                switch (sw)
                {
                    case 2:
                        lb.Lab1a2();
                        Console.ReadKey(true);
                        break;
                    case 3:
                        lb.Lab3();
                        Console.ReadKey(true);
                        break;
                    case 4:
                        lb.Lab4();
                        Console.ReadKey(true);
                        break;
                    case 5:
                        lb.Lab5();
                        Console.ReadKey(true);
                        break;
                    case 6:
                        lb.Lab6();
                        Console.ReadKey(true);
                        break;
                }
            } 
        }
    }

}
