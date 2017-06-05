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

    }

    public enum Genders : int
    {
        Male, Female
    }
}
