using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace Colecciones_Dictionary_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, string> estudiantes = new Dictionary<string, string>();

            estudiantes.Add("23-EISM-1-203", "SI");
            estudiantes.Add("23-EISM-1-123", "SI");
            estudiantes.Add("23-EISM-1-013", "NO");
            estudiantes.Add("23-EISM-1-001", "NO");
            estudiantes.Add("23-EISM-1-443", "SI");

            Console.WriteLine("Cantidad de elemento al principio {0}", estudiantes.Count);

            //Mostrando solo estudiantes activos
            Console.WriteLine("Estudiantes activos");
            foreach (KeyValuePair<string, string> elementos in estudiantes)
            {

                if (elementos.Value == "SI")
                    Console.WriteLine("Activo: {1} | Matricula: {0}", elementos.Key, elementos.Value );
                
            }

            //Mostrando estudiantes inactivos
            Console.WriteLine("Estudiantes inactivos");
            foreach (KeyValuePair<string, string> elementos in estudiantes)
            {

                if (elementos.Value == "NO")
                    Console.WriteLine("Activo: {1} | Matricula: {0}", elementos.Key, elementos.Value);

            }

            //Buscando a ver si se encuentra una clave en el diccionario
            Console.WriteLine("\nBuscando a ver si se encuentra una clave en el diccionario");
            Console.WriteLine(estudiantes.ContainsKey("23-EISM-1-123"));

            string valor = "";
            Console.WriteLine();
            //Buscando un valor por su clave y devolviendo TRUE O FALSE dependiendo si se encuentra
            Console.WriteLine("Buscando un valor por su clave y devolviendo TRUE O FALSE dependiendo si se encuentra");
            Console.WriteLine(estudiantes.TryGetValue("23-EISM-1123", out valor));

            //Eliminando un valor por su clave en este caso 23-EISM-1-203
            Console.WriteLine("Eliminando un valor por su clave en este caso 23-EISM-1-203");
            Console.WriteLine(estudiantes.Remove("23-EISM-1-203"));


            Console.WriteLine("Recorriendo el diccionario");
            foreach (KeyValuePair<string, string> elementos in estudiantes)
            {
                Console.WriteLine(elementos);
            }

            Console.WriteLine("Cantidad de elemento al final {0}", estudiantes.Count);

            Console.ReadKey();
        }
    }
}
