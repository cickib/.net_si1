using System;


namespace CreateClass
{
    class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders gender;

        public Person() { }
        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return String.Format("name: {0}, birth date: {1}", this.Name, this.BirthDate);
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "bella";
            DateTime date = new DateTime(1990, 12, 6);
            person.BirthDate = date;
            Console.WriteLine(person);
            Console.ReadKey();
        }
    }

    public enum Genders : int
    {
        Male, Female
    }
}
