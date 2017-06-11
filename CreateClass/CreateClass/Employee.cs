using System;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public int salary;
        public string profession;
        public Room room;

        public Employee(int salary, string profession, string name, DateTime birthDate, Genders gender) : base(name, birthDate, gender)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public override string ToString()
        {
            return String.Format("Employee: {0} was born on {1} {2} in {3}. Now " + getGender() + " is {4} and works as {5} for {6} salary.", 
                name, birthDate.Month, birthDate.Day, birthDate.Year, getAge(), profession, salary);
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            Room room = new Room(17);
            newEmployee.room = new Room(room.roomNumber);
            return newEmployee;
        }
    }
}