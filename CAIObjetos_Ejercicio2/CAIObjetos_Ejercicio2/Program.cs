using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIObjetos_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechanac = new DateTime(1998, 03, 04);
            Persona p1 = new Persona("Michelle", "Rosenblat", fechanac);
            p1.Caminar(3);
            Console.WriteLine ("La edad es " + p1.GetEdad());
            Console.WriteLine("La ubicacion es " + p1.Ubicacion);
            p1.Adoptar("Rocco");
            p1.Adoptar("Peque");
            p1.Adoptar("Negro");
            Console.WriteLine("Tenes " + p1.CantidadPerros() + " perros");
            Console.WriteLine("Tu felicidad es " + p1.Felicidad());
            
            Console.ReadLine();
     



        }
    }
}
