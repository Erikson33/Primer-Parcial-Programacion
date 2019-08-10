using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_de_progra_2do_SEmestre
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cliente1 = new La_empresa_Los_mara(3748, "Erikson Aurelio", "Samayoa Valdez", 234653, "Mazatenango", 54383730, "Alex Rodas", 1500);
            var Cliente2 = new La_empresa_Los_mara(3674, "Mario Eduardo", "Yes Gameros", 443567, "Guatemala", 26478634, "Alex Rodas", 1502);
            var Cliente3 = new La_empresa_Los_mara(2345, "Jorge Ivan", "Mazariegos Barillas", 325789, "Cuyotenango", 43734398, "Gabriel Cajas", 6000);
            Cliente1.mostrarDatos();
            Cliente2.mostrarDatos();
            Cliente3.mostrarDatos();

            //vectores
            var vector1 = new SumaVector(new List<int> { 1, 3, 5 });
            var vector2 = new SumaVector(new List<int> { 2, 5, 6 });
            SumaVector v3 = vector1.Suma(vector2);
            Console.WriteLine("\n\nSUMA");
            foreach (var i in v3.Componentes)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nResta");
            SumaVector v4 = vector1.Resta(vector2);
            foreach (var j in v4.Componentes)
            {
                Console.WriteLine(j);
            }
            SumaVector v5 = vector1.Multiplicar(vector2);
            Console.WriteLine("\nMultiplicacion");
            foreach (var k in v5.Componentes)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();
        }
    }
}
