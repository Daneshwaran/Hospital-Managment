using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

   public class Appointment
    {

        public int Hid { get; set; }
        public int DoctorID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public Patient PatientDetails = new Patient();
        public Doctor DoctorDetails = new Doctor();
            
    }
}
