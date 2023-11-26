using ConsoleApp._26._11._2023.Models;
using System.Security.Cryptography.X509Certificates;

public class Group
{
    public string? GroupNo { get; set; }
    public int StudentLimit { get; set; }
    private Student[] _students;


    public Group(string groupNo, int studentLimit)
    {
        GroupNo = groupNo;
        StudentLimit = studentLimit;
        _students = new Student[0];
    }

    public static bool CheckGroupNo(string groupNo)
    {
        if (groupNo.Length != 5)
            return false;

        for (int i = 0; i < groupNo.Length - 2; i++)
        {
            if (char.IsLetter(groupNo[i]) && groupNo[i].ToString().ToUpper() == groupNo[i].ToString().ToUpper())
            {
                continue;
            }
            return false;
        }

        for (int i = 2; i < groupNo.Length; i++)
        {
            if (!char.IsDigit(groupNo[i])) return false;
        }
        return true;
    }
    public void AddStudent(Student student)
    {
        if (_students?.Length < StudentLimit)
        {

            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
            Console.WriteLine("Student elave edildi");

        }
        Console.WriteLine("Limiti keçir"); // sen daha menalı şeylər yazarsan

    }
    public void GetAllStudents()
    {
        if (_students.Length>0)
        {
            foreach (var student in _students)
            {
                Console.WriteLine($"Id: {student.Id}, Fullname: {student.FullName}, Point: {student.Point}");
            }
            return;
        }
        Console.WriteLine("Group daxilinde telebe yoxdur.");
    }
    public void GetStudent(int? id)
    {
        if (id == null)
        {
            Console.WriteLine("Id null'dır");
            return;
        }


        var student = _students.FirstOrDefault(x => x.Id == id);

        if (student != null)
        {
            Console.WriteLine($"Id: {student.Id}, Fullname: {student.FullName}, Point: {student.Point}");
        }
        else
        {
            Console.WriteLine("Student tapılmadı");
        }
    }
}