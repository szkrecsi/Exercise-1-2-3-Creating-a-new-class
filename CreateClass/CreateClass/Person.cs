using System;

namespace CreateClass
{
    public enum Genders { Male, Female };

    class Person
    {
        public string name;
        public DateTime birthDate;
        public Genders gender { get; set; }

        public Person(string name, DateTime birthDate, Genders gender) {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
        }

        public override string ToString()
        {
            return String.Format("Person: {0} was born on {1} {2} in {3}. Now " + getGender() + " is {4}.",
                name, birthDate.Month, birthDate.Day, birthDate.Year, getAge());
        }

        public int getAge()
        {
            Console.WriteLine("What year is it?");
            int currentYear = Convert.ToInt32(Console.ReadLine());
            int birthYear = birthDate.Year;
            int Age = currentYear - birthYear;
            return Age;
        }

        public string getGender()
        {
            if (gender.Equals(Genders.Male)) {
                return "he";
            } else {
                return "she";
            }
        }
    }
}
