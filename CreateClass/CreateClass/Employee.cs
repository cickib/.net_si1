using System;

namespace CreateClass
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        public Room Room { get; set; }

        Employee()
        {
            Room = null;
        }

        Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            Salary = salary;
            Profession = profession;
            Room = null;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", salary: {0}, profession: {1}, room: {2}", Salary, Profession, Room);
        }

    }

    class Room
    {
        public int Number { get; set; }

        Room(int num)
        {
            Number = num;
        }
    }
}
