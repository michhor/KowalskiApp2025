using KowalskiApp.Lib.Models;

namespace KowalskiApp.Tests;

[TestClass]
public class StudentTest
{
    [TestMethod]
    public void SerializeObject_Student_DefaultString()
    {
        Student student = new Student();
        string expectedStudent = "Anonim, Gal";

        Assert.AreEqual(expectedStudent, student.ToString(),"Problem with serialization of default object");

    }
}
