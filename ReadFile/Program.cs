using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader myReader = new StreamReader("Files/myfile.txt");

            // This variable will store each line of the file.
            String line = "";

            // An empty line at the beginning of the output.
            Console.WriteLine();

            while(line != null)
            {

                line = myReader.ReadLine();

                if(line != null)
                {

                    Console.WriteLine(line);

                } // if

            } // while

            // Clossing the stream.
            myReader.Close();

            // An empty line at the end of the output.
            Console.WriteLine();

            // Wait for the user to press any key.
            Console.ReadLine();

        } // Main

    } // Program

} // ReadFile
