// C:\Users\Test\SimpleApi\Models\Student.cs
namespace SimpleApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }   // <-- Warning CS8618
    }
}

