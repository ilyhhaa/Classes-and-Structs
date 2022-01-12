using System;

namespace Classes_struct_and_namespaces
{

    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////
            ///////Basic Class//////////
            ////////////////////////////
            
            Human Ilya = new Human();

            Ilya.Name = "Ilya";
            Ilya.age = 23;
            Ilya.Surname = "Kunitsky";
            Ilya.Display();
            ////////////////////////////
            ///////Constructor//////////
            ////////////////////////////
            Console.WriteLine();
            Console.WriteLine();
            ForUseCtor forUseCtor = new ForUseCtor();
            forUseCtor.Display();
            ForUseCtor forUseCtor1 = new ForUseCtor(23);
            forUseCtor1.Display();
            ForUseCtor forUseCtor2 = new ForUseCtor("Ilya", 23);
            forUseCtor2.Display();
            ForUseCtor forUseCtor3 = new ForUseCtor() { str = "Ne Ilya", number = 35 };
            forUseCtor3.Display();
            Console.WriteLine();
            Console.WriteLine();
            ////////////////////////////
            ///////Struct///////////////
            ////////////////////////////
            Struct St; ///Непосредственная инициализация позволяет не вызывать конструктор
            St.Miles = 1;
            St.Direction = "Direction";
            St.Display();
            Struct2 struct2 = new Struct2("Led Zeppelin",4);
            struct2.Display();
            ////////////////////////////
            ///////Methods overload/////
            ////////////////////////////
            int Result;
            int Result1;
            int Result2;
           
            Method_Overload method_Overload = new Method_Overload();
            method_Overload.Add(1, 2, out Result);
            method_Overload.Add(1, 2,3, out Result1);
            method_Overload.Add(1, 2,3,4, out Result2);
            
            Console.WriteLine(Result);
            Console.WriteLine(Result1);
            Console.WriteLine(Result2);
            





        }


    }
}
