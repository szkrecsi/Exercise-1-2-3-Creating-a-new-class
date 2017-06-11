using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate = new DateTime(1980, 8, 17);
            Employee John = new Employee(1000, "programmer", "Adam", birthDate, Genders.Male);
            John.room = new Room(111);
            Employee John2 = (Employee)John.Clone();
            John2.room.roomNumber = 112;
            Console.WriteLine(John.ToString());
            Console.WriteLine(John2.ToString());
            Console.ReadKey();
        }
    }
}
