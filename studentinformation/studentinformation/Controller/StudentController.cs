using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using studentinformation.model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace studentinformation.Controllers
{
   
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        public int StudentID { get; set; }
        // GET api/values
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();
            IEnumerable<Student> result = studentDataAccessLayer.GetAllStudents();
            return result;
        }

        // GET api/values/5
       // [HttpGet("{id}")]
        //public Student Get(int id)
       // {
         //   StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();
           // var result = studentDataAccessLayer.GetStudentData(id);
            //return result;
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Student student)
        {
            StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();
            studentDataAccessLayer.AddStudent(student);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Student student)
        {
            if (id != student.StudentID)
            {
                return NotFound();
            }
            StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();
            studentDataAccessLayer.UpdateStudent(student);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            StudentDataAccessLayer studentDataAccessLayer = new StudentDataAccessLayer();
            studentDataAccessLayer.DeleteStudent(id);
            return Ok();
        }
    }
}



