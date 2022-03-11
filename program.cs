using System;
using System.Collections.Generic;
using System.Threading;


namespace SegonExerciciAvaluacioContinuada
{
    class Program
    {
        static Random rdn = new Random();
        static MarioBross player;
        static List<Personatge> Enemics;
        static ConsoleKeyInfo cki;
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Init();

            while (player.GetVida() > 0)
            {
                Update();
                Mostrar();
                player.CheckPosition(Enemics);

                Thread.Sleep(700);
            }
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tHas Mort");
            Console.ResetColor();

        }
        private static void Init()
        {
            // PENDENT IMPLEMENTAR

            Console.Write("Escriu 1 si vols jugar amb Mario o 2 si vols jugar amb Yoshi");

            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    player mario = new player(mario);
                }
                if (n == 2)
                {
                    player yoshi = new player(yoshi);
                }
            }
            catch (Exception)
            {
                Console.Write("valor no vàlid");
            }

        }
        private static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("Vida : " + player.GetVida());
            player.Mostrar();

            // PENDENT IMPLEMENTAR

        }
        private static void Update()
        {
            if (!player.Update() && Console.KeyAvailable)
            {
                player.Moure(Console.ReadKey());
            }

            foreach (Personatge e in Enemics)
            {
                e.Moure(cki);
            }

            if (rdn.NextDouble() < 0.1) Enemics.Add(new Personatge());


        }

    }


}