// See https://aka.ms/new-console-template for more information
using System;
namespace EjemploClase
{
    class Program
    { 
            static void Main(string[] args)
        {
            string name = "josé alberto";
            string lastname = "Arvide Aquino";
            //Escribir una sola línea con Write
            Console.Write("josé alberto");
            Console.Write("Arvide Aquino");
            Console.Write("No.control");

            //Escribir con saltos de línea
            Console.WriteLine("josé alberto");
            Console.WriteLine("Arvide Aquino");
            Console.WriteLine("No.control");
            Console.WriteLine("20222142");
            Console.WriteLine("Programacion II");

            //Escribir saltos de línea pero con tipos de datos impresación
            Console.WriteLine("Hola " + name);
            Console.WriteLine("Hola " + lastname);

            //Escribir por medio de RedLine con WriteLine
            Console.WriteLine("Hola , ingresa tu nombre");
            Console.WriteLine("Hola " + Console.ReadLine() + " bienvenido");
        }
    }
}
