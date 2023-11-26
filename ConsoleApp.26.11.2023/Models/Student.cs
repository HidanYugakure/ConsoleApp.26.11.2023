namespace ConsoleApp._26._11._2023.Models
{
    public class Student
    {
        private static int MaxId = 1;
     
        public int Id { get; }
        public string FullName { get; set; }
        public double Point { get; set; }

        public Student(string fullName, double point)
        {
            Id = MaxId++;
            FullName = fullName;
            Point = point;
        }
        public void studentInfo()
        {
            Console.WriteLine($"User ID: {Id}");
            Console.WriteLine($"Fullname: {FullName}");
            Console.WriteLine($"Point: {Point}");
        }
    }
}
