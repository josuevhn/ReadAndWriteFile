using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Libreria necesaria para utilizar StreamReader.
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creamos una instancia de StreamReader.
            StreamReader myReader = new StreamReader("Files/myfile.txt");

            // Esta variable almacenará cada línea del archivo.
            String line = "";

            // Línea en blanco al inicio de la salida en pantalla.
            Console.WriteLine();

            // Iteramos sobre cada línea del archivo hasta llegar al final del mismo.
            while(line != null)
            {

                // Leemos la línea a la que apunta nuestro objeto myReader.
                line = myReader.ReadLine();

                // Comprobamos que no hemos llegado al final del archivo.
                if(line != null)
                {

                    // Imprimimos la línea en pantalla.
                    Console.WriteLine(line);

                } // if

            } // while

            // Cerramos el flujo al arhcivo.
            myReader.Close();

            // Línea en blanco al final de la salida en pantalla.
            Console.WriteLine();

            // Esperamos a que el usuario presione cualquier tecla.
            Console.ReadLine();

        } // Main

    } // Program

} // ReadFile
