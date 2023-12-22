

using _26._11._2023.Domain;
using _26._11._2023.Domain.Models;

Group group = new("P518", 20);
Student student1 = new();
student1.FullName = "Tahir ASlanli";
student1.Point = 89;
Student student2 = new();
student2.FullName = "Babek ASlanli";
student2.Point = 80;
List<Student> students = new();
group.AddStudent(student1);
group.AddStudent(student2);
Console.WriteLine(group.GroupNo,group.StudentLimit);
foreach(var student in students)
{
    Console.WriteLine( student.Point);
}

