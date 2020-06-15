using System;

namespace TimeSpanRepresentandoDuracoesAula91
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine();

            TimeSpan t2 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine();

            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);
            Console.WriteLine();

            TimeSpan t4 = new TimeSpan(2, 11, 21);
            Console.WriteLine(t4);
            Console.WriteLine();

            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t5);
            Console.WriteLine();

            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);// 321milesegundos
            Console.WriteLine(t6);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // como instanciar um TimeSpan usando o metodo From


            TimeSpan t7 = TimeSpan.FromDays(1.5);// 1.5 --> significa um dia e meio
            Console.WriteLine(t7);
            Console.WriteLine();
                        
            TimeSpan t8 = TimeSpan.FromHours(1.5);// uma hora e meia
            Console.WriteLine(t8);
            Console.WriteLine();

            TimeSpan t9 = TimeSpan.FromMinutes(1.5);// um minuto e meio
            Console.WriteLine(t9);
            Console.WriteLine();

            TimeSpan t10 = TimeSpan.FromSeconds(1.5);// um segundo e meio
            Console.WriteLine(t10);
            Console.WriteLine();

            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);// milesegundo e meio
            Console.WriteLine(t11);
            Console.WriteLine();

            TimeSpan t12 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t12);
            Console.WriteLine();


        }
    }
}
