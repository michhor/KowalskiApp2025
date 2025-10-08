namespace KowalskiApp.Lib.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public Student(string name, string firstname)
        {
            Name = name;
            FirstName = firstname;
        }

        public Student()
        {
            Name = "Anonim";
            FirstName = "Gal";
        }

        public override string ToString()
        {
            return $"{Name}, {FirstName}";
        }
    }
}