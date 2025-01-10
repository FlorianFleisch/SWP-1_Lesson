using OOP_School;

public class SchoolClasses : School
{
    public string ClassName { get; set; }

    private List<Student> Students;
    public void addStudentToClass(Student a)
    {
        Students.Add(a);
    }

    public SchoolClasses(string className, string schoolName, string schoolType, string schoolLocation)
        : base(schoolName, schoolType, schoolLocation)
    {
        ClassName = className;
        Students = new List<Student>();
    }
}