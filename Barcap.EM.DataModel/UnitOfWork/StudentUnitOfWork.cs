using Barcap.EM.DataModel.Models;
using Barcap.EM.DataModel.StudentsRepository;
using MongoDB.Driver;
using System;
using System.Configuration;

namespace Barcap.EM.DataModel.UnitOfWork
{
    public class StudentUnitOfWork
    {
        private IMongoDatabase _database;
        protected StudentRepository<Student> _students;

        public StudentUnitOfWork()
        {
            var connectionString = Convert.ToString(ConfigurationManager.AppSettings["MongoDBConnectionString"]);
            var dbName = Convert.ToString(ConfigurationManager.AppSettings["databaseName"]);

            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(dbName);

        }

        public StudentRepository<Student> Students
        {
            get
            {
                if (_students == null)
                    _students = new StudentRepository<Student>(_database, "students");
                return _students;
            }
        }

    }
}
