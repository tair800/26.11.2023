using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _26._11._2023.Domain.Models
{
    public class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit { get; private set; }
        private Student[] Students;
        public Group(string groupNo, int studentLimit)
        {

            if (!CheckGroupNo(groupNo))
            {
                Console.WriteLine("Invalid group number");
            }

            GroupNo = groupNo;
            SetStudentLimit(studentLimit);
            Students = new Student[0];


        }
        private bool CheckGroupNo(string groupNo)
        {
            if (!Regex.IsMatch(groupNo, "^[A-Z]{2}.+")) return false;
            if (!Regex.IsMatch(groupNo, "[1-9] 3")) return false;
            return true;
        }
        private void SetStudentLimit(int studentLimit)
        {
            if (studentLimit > 5 || studentLimit < 18)
            {
                Console.WriteLine("Student Limit must bee between 5 and 18");
            }
            StudentLimit=studentLimit;
           
        }
        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, StudentLimit+1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine();
            }
        }
        public Student GetStudent(int? id)
        {
            if (id.HasValue)
            {
                return Students.FirstOrDefault(s=>s.Id==id);
            }
            return null;
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }
            
    }
    
}
