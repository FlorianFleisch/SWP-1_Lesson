namespace OOP_School
{
    public class School
    {
        public string SchoolName { get; set; }

        public string SchoolLocation { get { return _SchoolLocation; } }
        private string _SchoolLocation;

        public string Schooltype { get { return _Schooltype; } }
        private string _Schooltype;

        public School(string schoolName, string schooltype, string schoolloctaion)
        {
            SchoolName = schoolName;
            _Schooltype = schooltype;
            _SchoolLocation = schoolloctaion;
        }
    }
}