using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace cuadro

{
    class cuadro
    {
        static void Main(string[] args)
        {
            string[] dim = new string[5];

            dim[4] = "111111111111111";

            dim[1] = "100000000000001";

            dim[3] = "100000000000001";

            dim[2] = "100000000000001";

            dim[0] = "111111111111111";


            Console.WriteLine("Cuadro");

            Console.WriteLine("{dim[0]}");

            Console.WriteLine("{dim[1]}");

            Console.WriteLine("{dim[2]}");

            Console.WriteLine("{dim[3]}");

            Console.WriteLine("{dim[4]}");

        }
    }
}

