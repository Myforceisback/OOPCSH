using System;
using System.Collections.Generic;

namespace OOPCSH
{
    partial class Labs
    {
        public Labs() { }

        delegate void Fin();

        delegate void Fout();
        public void Lab1a2()
        {
            int sw;
            Film fl = new Film();
            Actors act = new Actors();
            Music mus = new Music();
            Compositors com = new Compositors();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lab1 Active");
                Console.WriteLine("1. Film");
                Console.WriteLine("2. Actors");
                Console.WriteLine("3. Music");
                Console.WriteLine("4. Compositor");
                Console.WriteLine("5. Вывод всех классов");
                Console.WriteLine("0. Выход");
                Console.Write("Введите номер - ");
                sw = Int32.Parse(Console.ReadLine());
                if (sw == 0)
                    break;
                switch (sw)
                {
                    case 1:
                        Console.Clear();
                        fl.input();
                        Console.ReadKey(true);
                        break;
                    case 2:
                        Console.Clear();
                        act.input();
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.Clear();
                        mus.input();
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.Clear();
                        com.input();
                        Console.ReadKey(true);
                        break;
                    case 5:
                        Console.Clear();
                        fl.output();
                        Console.WriteLine();
                        act.output();
                        Console.WriteLine();
                        mus.output();
                        Console.WriteLine();
                        com.output();
                        Console.ReadKey(true);
                        break;
                }
            }
        }
        public void Lab3()
        {
            Compositors test = new Compositors();
            Compositors test1 = new Compositors();
            test.input();
            bool a = test == "alinaD";

            test1.input();

            test = test / test1;

            test.output();
        }
        public void Lab4()
        {
            //Задание 1
            Console.Clear();
            Console.WriteLine("Задание 1");
            Music[] del = new Music[5];
            for (int i = 0; i < 5; ++i)
            {
                del[i] = new Music();
            }
            Fin inp = new Fin(del[0].input);
            Fout otp = new Fout(del[0].output);
            inp();
            otp();
            Console.ReadKey(true);

            //Задание 2
            Console.Clear();
            Console.WriteLine("Задание 2");
            for (int i = 1; i < 5; ++i)
            {
                inp += del[i].input;
                otp += del[i].output;
            }
            inp();
            otp();
            Console.ReadKey(true);

            //Задание 3
            Console.Clear();
            Console.WriteLine("Задание 3");
            for (int i = 0; i < 5; ++i)
            {
                inp -= del[i].input;
                otp -= del[i].output;
            }
            if (inp == null && otp == null)
                Console.WriteLine("увы");
            else
                Console.WriteLine("эээээ");
            Console.ReadKey(true);
        }
        public void Lab5()
        {
            List<Music> mycollection = new List<Music>();
            Music go = new Music();
            go.input();
            mycollection.Add(new Music("IMMORTAL - OldFlop", 3, "D - Janklod Vandam Terminator", "Drunk man", "Thriller"));
            mycollection.Add(go);
            foreach (var item in mycollection)
            {
                Console.WriteLine("Derived 1: {0}, {1}, {2}, {3}, {4}", item.NameFilm, item.Stud, item.Prod, item.Genre, item.NameMusic);
            }
            
            Serializator.Serialize("data.bin", mycollection);
            
            mycollection.Clear();
            Console.WriteLine("clear");

            var deserialize = Serializator.Deserialize<List<Music>>("data.bin");
            foreach (var item in deserialize)
            {
                Console.WriteLine("Derived 1: {0}, {1}, {2}, {3}, {4}", item.NameFilm, item.Stud, item.Prod, item.Genre, item.NameMusic);
            }

            //заготовочка для доп задания )
            //int sizeCol = mycollection.Count();
            //Music[] dser = new Music[sizeCol];
            //for (int i = 0; i < sizeCol; ++i)
            //{
            //    dser[i] = new Music(mycollection);
            //}
            Console.ReadKey(true);
        }
        public void Lab6()
        {
            Film flm = new Film();
            Music mus = new Music();
            Actors act = new Actors();
            Compositors comp = new Compositors();
            flm.SetInt();
            flm.SetString();
            flm.output();
            Console.WriteLine("Пeрвый пошел!");
            IMusic(ref mus);
            OMusic(ref mus);
            Console.WriteLine("Второй пошел!");
            IActors(ref act);
            OActors(ref act);
            Console.WriteLine("Третий пошел!");
            ICompositors(ref comp);
            OCompositors(ref comp);
            Console.WriteLine("усё");
            Console.ReadKey(true);
        }
    }
}
