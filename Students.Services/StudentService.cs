using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barcap.EM.DataModel.Models;
using Barcap.EM.DataModel.UnitOfWork;

namespace Students.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentUnitOfWork _sUnitOfWork;

        public StudentService()
        {
            this._sUnitOfWork = new StudentUnitOfWork();
        }

        public void Delete(int i)
        {
            throw new NotImplementedException();
        }

        public Student Get(int i)
        {
            return _sUnitOfWork.Students.Get(i);
        }

        public IEnumerable<Student> GetAll()
        {
            return _sUnitOfWork.Students.GetAll();
        }

        public void Insert(Student s)
        {
            throw new NotImplementedException();
        }

        public void Update(Student s)
        {
            throw new NotImplementedException();
        }
    }
}
