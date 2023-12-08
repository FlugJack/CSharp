using System;

namespace HolaMundo
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Holla Mundo
            Console.WriteLine("Hola Mundo");

            /*
            Varios comentarios 
            */
            
            //Creacion de variables

            string myString = "Esto es una cadena de texto";
            Console.WriteLine(myString);

            int myInt = 7;
            myInt ++;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt-1);
            Console.WriteLine(myInt);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            double MyDouble = 6.4;
            Console.WriteLine(MyDouble);

            bool myBool = true;
            Console.WriteLine(myBool);

            //CSharp trata a todos como datos numericos
            Console.WriteLine(myInt + myFloat + MyDouble);

            //Variables dinamicos

            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinamico";
            Console.WriteLine(myDynamic + myFloat);

            // La variable es de tipo inferido

            var myVar = "Mi variable de tipo inferido";
            // myVar = 6; Error
            Console.WriteLine(myVar);

        }
    }
}

