using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entityframework.Data;
using entityframework.model;
using Microsoft.AspNetCore.Mvc;

namespace entityframework.Controllers
{
    [Route("api/[Student]")]
    public class StudentController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            using( var _context = new StudentContext() )
            {
                var listofStudents = new List<Studententity>();
                listofStudents = _context.TableStudent.ToList();
                return Ok(listofStudents);
            }
        }
        // POST api/values
        [HttpPost]
        public Actioa Post([FromBody]Studententity StudentObject)
        {
            using (var _context = new StudentContext())
            {
                _context.TableStudent.Add(StudentObject);
                _context.SaveChanges();
            }
            return Ok("student added");
        }
        [HttpPut]
        public ActionResult Put([FromBody]Studententity StudentObject)
        {
            using (var _context = new StudentContext())
            {
                _context.TableStudent.Update(StudentObject);
               _context.SaveChanges();
            }
            return Ok("StudentUpdated");
        }
        // DELETE api/values/5
        [HttpDelete]
        public ActionResult Delete([FromBody]Studententity StudentObject)
        {
            using (var _context = new StudentContext())
            {
                _context.TableStudent.Remove(StudentObject);
                _context.SaveChanges();
            }
            return Ok("StudentDeleted");
        }
    }
}
