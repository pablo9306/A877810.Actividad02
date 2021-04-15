using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A877810.Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {
            int oper;
            Console.WriteLine("Ingrese la cantidad de operadores");
            oper = Int32.Parse(Console.ReadLine());
            int[] cantoper = new int[oper];
            int qty;
            Console.WriteLine("Ingrese la cantidad de órdenes de trabajo");
            qty = Int32.Parse(Console.ReadLine());
            int[] cantoord = new int[qty];
            /*for (int i = 0; i < qty; i++)
            {
                Console.WriteLine("El número de órden es: " + i);
                Console.WriteLine("Órden " + cantoord[i] + " asignada");
            }*/
            Console.Clear();
            Console.WriteLine("Se mostrará el listado de operadores.");
            for (int i = 0; i < oper; i++)
            {
                Console.WriteLine("Los operadores son: " + i);
                Console.WriteLine("Tiene " + cantoper[i] + " trabajos asignados");
            }
            Console.WriteLine("Indicar operador para asignarle una órden de trabajo");
            Console.ReadLine();
            /*Console.WriteLine("El número de operadores es: " + oper);
            Console.WriteLine("La cantidad de órdenes de trabajo son: " + qty);*/
            }
    }
}
