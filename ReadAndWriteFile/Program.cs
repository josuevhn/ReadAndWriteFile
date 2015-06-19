using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Libreria necesaria para utilizar StreamReader y StreamWriter.
using System.IO;

namespace ReadAndWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {

            // Leer Archivo

            // Creamos una instancia de StreamReader.
            using (StreamReader streamReader = new StreamReader("Files/myfile.txt"))
            {

                // Esta variable almacenará el texto a escribir.
                String line = "";

                // Línea en blanco.
                Console.WriteLine();

                Console.WriteLine("Reading Text:");

                // Línea en blanco.
                Console.WriteLine();

                // Iteramos sobre cada línea del archivo hasta llegar al final del mismo.

                do
                {

                    // Leemos la línea a la que apunta nuestro objeto myReader.
                    line = streamReader.ReadLine();

                    // Imprimimos la línea en pantalla.
                    Console.WriteLine(line);

                } while (line != null);

            } // using

            // Escribir Archivo

            using(StreamWriter streamWriter = new StreamWriter("Files/myfile.txt", false))
            {

                // Línea en blanco.
                Console.WriteLine();

                Console.WriteLine("Writing Text:");

                // Esta variable almacenará cada línea del archivo.
                String text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent ac odio nibh. Nam sodales diam sed dolor tempor, at viverra est ultrices. Nunc justo tortor, euismod suscipit rutrum ac, tempus sed orci. Vivamus facilisis neque ac diam sagittis venenatis. Pellentesque ut justo vel eros consectetur volutpat ut sed felis. Cras tristique velit purus, vel commodo nibh finibus at. Aliquam vitae ligula orci. Mauris ullamcorper iaculis felis, at rutrum metus. Duis eget ultrices eros. Cras dapibus, lacus ut feugiat cursus, arcu odio condimentum neque, non rhoncus libero ligula ac augue. Proin vitae semper ex. Integer mollis pellentesque aliquam.";

                // Línea en blanco.
                Console.WriteLine();

                Console.WriteLine(text);

                // Línea en blanco.
                Console.WriteLine();

                // Escribimos texto hacia el archivo.
                streamWriter.WriteLine(text);

            } // using

            // Esperamos a que el usuario presione cualquier tecla.
            Console.ReadLine();

        } // Main

    } // Program

} // ReadAndWriteFile
