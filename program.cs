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