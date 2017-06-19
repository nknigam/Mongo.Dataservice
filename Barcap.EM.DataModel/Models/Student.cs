using MongoDB.Bson.Serialization.Attributes;

namespace Barcap.EM.DataModel.Models
{
    public class Student
    {
        [BsonElement("_id")]
        public int StudentId { get; set; }

        [BsonElement("RollNo")]
        public string RollNumber { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Class")]
        public string StudentClass { get; set; }
    }
}
