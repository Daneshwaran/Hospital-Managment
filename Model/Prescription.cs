using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Prescription
    {
        public int AppointmentId { get; set; }
        public int Hid { get; set; }
        public int DoctorId { get; set; }
        public string Date { get; set; }
        public string PrescriptionDetails { get; set; }
        public string Remark { get; set; }
        public Appointment AppointmentDetails = new Appointment();
    }
}
