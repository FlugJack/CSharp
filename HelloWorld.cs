using System;
using System.Globalization;
using System.Timers;

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

            Console.WriteLine($"El valor de mi entero es {myInt} y el de bool {myBool}");

            //Creacion de Constantes

            const string MyConst = "Mi constante";
            Console.WriteLine(MyConst);

            //Estructuras
            var myArray = new string[] {"Johan", "Chan", "FlugJack"};
            Console.WriteLine(myArray[2]);

            myArray[2] = "36";
            Console.WriteLine(myArray[2]);

            //Librerias

            var myDictionary = new Dictionary<string, int>
            {
                {"FlugJack", 21},
                {"Balderas", 20},
                {"Jessyca", 19}
            };

            Console.WriteLine(myDictionary["Jessyca"]);

            var mySet = new HashSet<String> {"Johan", "Chan", "FlugJack", "FlugJack"};
           
            var myTuple = ("Johan", "Chan", "FlugJack");
            Console.WriteLine(myTuple);

            //Bucles

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }

            foreach (var myIntem in myArray)
            {
                Console.WriteLine(myIntem);   
            }

            foreach (var myIntem in myDictionary)
            {
                Console.WriteLine(myIntem);   
            }

            foreach (var myIntem in mySet)
            {
                Console.WriteLine(myIntem);   
            }

            //Flujos

            if(myInt == 11 && myBool == true)
            {
                Console.WriteLine("El valor es 11");
            }
            else if(myInt == 12 || myBool == false){
                Console.WriteLine("El valor es 12");
            }
            else{
                Console.WriteLine("El valor no es 11");
            }

            MyFuncion();
            Console.WriteLine(MyFuncionWithReturn(5));

            var MyClass = new MyClass("Johan");
            MyClass.myName = "FlugJack";
            Console.WriteLine(MyClass.myName);
        }
        //Funciones que no retorna valor 

        static void MyFuncion()
        {
            Console.WriteLine("Mi función");
        }

        //Funcion que retorna valor 

        static int MyFuncionWithReturn(int param)
        {
            return 10 + param;
        }

        class MyClass
        {
            public string myName { get;set; }

            public MyClass(string myName)
            {
                this.myName = myName;
            }        
        }
    }
}

