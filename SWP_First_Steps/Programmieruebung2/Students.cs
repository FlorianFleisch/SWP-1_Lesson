public class Student : Person
{
    public string SchoolClass { get; set; }

    public Student(string geschlecht, DateTime geburtsdatum, string schoolClass)
        : base(geschlecht, geburtsdatum)
    {
        SchoolClass = schoolClass;
    }
}
