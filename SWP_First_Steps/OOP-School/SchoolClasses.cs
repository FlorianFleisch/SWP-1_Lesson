public class SchoolClass
{
    public List<SchoolClass> SchoolClasses { get; set; } = new List<SchoolClass>();
    public string ClassName { get; set; }

    public SchoolClass(string className)
    {
        ClassName = className;
    }

    public override string ToString()
    {
        return ClassName;
    }
}