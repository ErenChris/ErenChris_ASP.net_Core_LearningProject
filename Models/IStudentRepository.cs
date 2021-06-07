using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagment.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int ID);
    }
}
