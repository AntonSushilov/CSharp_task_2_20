using System;
using TaskLogic;

namespace CSharp_task_2_20
{
    class Program
    {
        static string name;
        static int speakers;
        static int members;
        static int p;
        static void Main(string[] args)
        {
            Input();
            Rally r = new Rally(name, speakers, members);
            Orator o = new Orator(name, speakers, members, p);
            Output(r, o);
            Console.ReadKey();
        }
        static void Input()
        {
            Console.WriteLine("Введите информацию о событии:");
            name = Console.ReadLine();
            speakers = int.Parse(Console.ReadLine());
            members = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число групп ораторов, которые высказывали одинаковые мысли:");
            p = int.Parse(Console.ReadLine());
        }

        static void Output(Rally r, Orator o)
        {

            r.GetInfo();
            o.GetInfo();
            foreach (string s in r.info)
            {
                Console.WriteLine(s);
            }
            foreach (string s in o.info)
            {
                Console.WriteLine(s);
            }

        }

    }
}
