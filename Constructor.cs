using System;
namespace Classes_struct_and_namespaces
{
    class ForUseCtor
    {
        public void Display()
        {
            Console.WriteLine($"Числа переданные в конструктор:{number} , Строка переданная в конструктор: {str}");
        }
        public int number;
         public string str;
        public ForUseCtor(string str , int number)
        {
            this.str = str ;
            this.number = number;
        }
        public ForUseCtor(int number)
        {
            this.number = number;
        }
        public ForUseCtor()
        {
            Console.WriteLine("Конструктор учаествует в создании объекта");
            number = 228;
            str = "Two hundred twenty eight";
        }
    }
}
