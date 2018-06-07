using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapp.Controllers
{
    public class TraineeController : ApiController
    {
        List<Trainee> names = new List<Trainee>
        {
        new Trainee{Tname="shivani",Tid=01, Age=20},
        new Trainee{Tname="renuka",Tid=02,Age=12}
        };
        public List<Trainee> Post(Trainee trainee)
        {
            names.Add(trainee);
            return (names);
        }
        public List<Trainee> Get()
        {
            return names;
        }
        public List<Trainee> Put(Trainee trainee)
        {
         int index = names.FindIndex(p => p.Tid == trainee.Tid);
            return names;
        }
        public List<Trainee> Delete(int Tid)
        {  



            return names;
        }


        public class Trainee
        {
            public string Tname { get; set; }
            public int Tid { get; set; }
            public int Age { get; set; }

        }
    }
    
}
