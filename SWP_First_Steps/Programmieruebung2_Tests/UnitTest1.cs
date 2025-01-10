namespace Programmieruebung2_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddStudent_ShouldAddStudentToList()
        {
            var school = new School();
            var student = new Student("männlich", new DateTime(2005, 5, 10), "3bWi");
            school.AddStudent(student);
            Assert.AreEqual(1, school.GetNumberOfStudents());
        }

        [Test]
        public void TestGetMaleAndFemaleStudentCount()
        {
            var school = new School();
            var maleStudent = new Student("männlich", new DateTime(2005, 5, 10), "3aWi");
            var femaleStudent = new Student("weiblich", new DateTime(2006, 7, 15), "3bWi");
            school.AddStudent(maleStudent);
            school.AddStudent(femaleStudent);
            var (male, female) = school.GetMaleAndFemaleStudentCount();
            Assert.AreEqual(1, male);
            Assert.AreEqual(1, female);
        }

        [Test]
        public void AddClassroom_ShouldAddClassroomToList()
        {
            var school = new School();
            var classroom = new Classroom("Large", 30, true);
            school.AddClassroom(classroom);
            Assert.AreEqual(1, school.GetNumberOfClassrooms());
        }

        [Test]
        public void TestGetAverageAge()
        {
            var school = new School();
            var student1 = new Student("männlich", new DateTime(2005, 5, 10), "3aWi");
            var student2 = new Student("weiblich", new DateTime(2006, 7, 15), "3bWi");
            school.AddStudent(student1);
            school.AddStudent(student2);
            var averageAge = school.GetAverageAge();
            Assert.AreEqual(19, averageAge, 0.5);
        }

        [Test]
        public void TestCanClassFitInRoom()
        {
            var school = new School();
            var classroom = new Classroom("Large", 30, true);
            var student1 = new Student("männlich", new DateTime(2005, 5, 10), "3aWi");
            var student2 = new Student("weiblich", new DateTime(2006, 7, 15), "3bWi");
            school.AddStudent(student1);
            school.AddStudent(student2);
            var canFit = school.CanClassFitInRoom("3aWi", classroom);
            Assert.IsTrue(canFit);
        }
    }
}
