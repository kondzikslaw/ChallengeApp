namespace ChallengeApp
{
    public abstract class Person
    {
        public Person()
            : this("N/A", "N/A", "N/A")
        {

        }
        public Person(string name)
            : this(name,"N/A", "N/A")
        {

        }
        public Person(string name, string surname)
            : this(name, surname, "N/A")
        {
            
        }
        public Person(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set;}

    }
}
