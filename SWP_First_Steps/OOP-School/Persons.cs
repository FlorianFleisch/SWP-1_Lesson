namespace OOP_School
{
    public class Person 
    {
        public string Name { get; set; }
        private DateTime _Birthday { get; set; }

        public int Age
        {
            get
            { return DateTime.Now.Year - _Birthday.Year; }
        }

        public Person(string name, DateTime birthday) 
        {
            Name = name;
            _Birthday = birthday;
        }
    }
}
