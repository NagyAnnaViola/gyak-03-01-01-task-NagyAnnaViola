using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using gyak_03_01_01_task_NagyAnnaViola.model;

namespace gyak_03_01_01_task_NagyAnnaViola
{
    class Program
    {
        static void Main(string[] args)
        {
            //kis kendő példányosítás
            Fonal kisKendo = new Fonal("Csillogós fonal", 5);
            Console.WriteLine(kisKendo);

            Fonal nagyKendo = new Fonal("Szivárványos fonal", 8);
            Console.WriteLine(nagyKendo);

            Kendo vasarlo = new Kendo("Kisduci Illés", kisKendo, nagyKendo);
            Console.WriteLine("\t"+vasarlo+"\n");

            //hozzáadás, elvétel
            kisKendo.Add(5);
            kisKendo.Remove(2);
            nagyKendo.Add(3);
            nagyKendo.Remove(2);
            Console.WriteLine(kisKendo);
            Console.WriteLine(nagyKendo);

            //vegyesen
            vasarlo.Buying(nagyKendo, kisKendo, 20);
            Console.WriteLine(vasarlo + "\n");

            //hibatesztelés 1 fonal esetén
            Fonal order = new Fonal("Csillogós", 1);
            Console.WriteLine("\n");

            try
            {
                vasarlo.Buying(nagyKendo, kisKendo, 20);
                Console.WriteLine(vasarlo + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Debug.WriteLine(e.Message);
            }
            Console.ReadKey();
                 
        }
    }
}
