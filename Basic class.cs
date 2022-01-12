using System;
namespace Classes_struct_and_namespaces
{
    
        public class Human
        {
        public Human()
        {
            Console.WriteLine("Создаие конструктора");
        }
            DateTime birthday = new DateTime(1998, 12, 07);

            public string Surname { get; set; }
            public string Name { get; set; }
            public int age { get; set; }
            public void Display()
            {
                Console.WriteLine($"Возраст {age} , Имя {Name}, Фамилия {Surname} , День Рождения {birthday} ");
            }
        }
    
}
