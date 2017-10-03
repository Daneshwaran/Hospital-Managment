using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Discharge
    {
        public int DischargeId{ get; set; }
        public int Hid { get; set; }
        public int WardNo { get; set; }
        public string AdmitDate { get; set; }
        public int DoctorId { get; set; }
        public string DischargeDate { get; set; }
    }
}
