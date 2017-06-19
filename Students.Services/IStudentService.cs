using Barcap.EM.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Services
{
    public interface IStudentService
    {
        void Insert(Student s);

        Student Get(int i);

        IEnumerable<Student> GetAll();

        void Delete(int i);

        void Update(Student s);

    }
}



