using Students.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mongo.Dataservice.Controllers
{
    public class StudentController : ApiController
    {
        private IStudentService studentService;

        public StudentController()
        {
            this.studentService = new StudentService();
        }

        public HttpResponseMessage GetAll()
        {
            var students = studentService.GetAll();
            if (students.Any())
                return Request.CreateResponse(HttpStatusCode.OK, students);

            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Student found!!");
        }

        public HttpResponseMessage Get(int id)
        {
            var student = studentService.Get(id);

            if (student!=null)
                return Request.CreateResponse(HttpStatusCode.OK, student);

            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student Not found for given Id!!");

        }
    }
}
