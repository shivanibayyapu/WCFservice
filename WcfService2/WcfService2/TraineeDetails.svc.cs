using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class TraineesService : ITraineesService
    {
        public static List<Trainees> trainees = new List<Trainees>()
        {
            new Trainees {TraineeId=1,Name="renu",Age=20,DOB=new DateTime(1997,4,5) },
            new Trainees {TraineeId=2,Name="shi",Age=20,DOB=new DateTime(1997,6,30) }
        };
        public List<Trainees> AddTraniee(Trainees addNewTrainee)
        {
            trainees.Add(addNewTrainee);
            return trainees;
        }
        public List<Trainees> DeleteTrainee(int deletedTraineeId)
        {
            var deletingTrainee = trainees.Find(t => t.TraineeId == deletedTraineeId);
            trainees.Remove(deletingTrainee);
            return trainees;
        }
        public List<Trainees> GetTrainee()
        {
            return trainees;
        }
        public List<Trainees> UpdateTrainee(Trainees updatedTrainee)
        {
            var deletingTrainee = trainees.Find(t => t.TraineeId == updatedTrainee.TraineeId);
            if (deletingTrainee == null)
                trainees.Add(updatedTrainee);
            else
            {
                trainees.Remove(deletingTrainee);
                trainees.Add(updatedTrainee);
            }
            return trainees;
            //throw new NotImplementedException();
        }
    }
}
