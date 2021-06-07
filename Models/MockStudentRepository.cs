using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagment.Models
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _studentList;

        public MockStudentRepository()
        {
            _studentList = new List<Student>()
            {
                new Student(){ ID = 1, Name = "A", ClassName = "GradeOne", EmailAddress = "A@email.com" },
                new Student(){ ID = 2, Name = "B", ClassName = "GradeTwo", EmailAddress = "B@email.com" },
                new Student(){ ID = 2, Name = "C", ClassName = "GradeTwo", EmailAddress = "B@email.com" }
            };
        }

        public Student GetStudent(int ID)
        {
            return _studentList.FirstOrDefault(a => a.ID == ID);
        }
    }
}
