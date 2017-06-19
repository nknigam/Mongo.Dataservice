using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Barcap.EM.DataModel.StudentsRepository
{
    public class StudentRepository<T> where T: class
    {
        IMongoDatabase _db;
        string _tableName;
        IMongoCollection<T> _collection;

        public StudentRepository(IMongoDatabase db, string tblName)
        {
            _db = db;
            _tableName = tblName;
            _collection = _db.GetCollection<T>(tblName);
        }

        public T Get(int id)
        {
            var filter = Builders<T>.Filter.Eq("_id", id);
            return _collection.Find(filter).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            var list = _collection.Find(_ => true).ToList();
            return list;
        }


    }
}
