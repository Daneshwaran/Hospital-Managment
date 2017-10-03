using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Admit
    {

        public int HospitalId { get; set; }
        public int DoctorId { get; set; }
        public string AdmitDate { get; set; }
        public int WardNumber { get; set; }
        public int AdmitId { get; set; }

        public Appointment AppointmentDetails = new Appointment();

    }
}
