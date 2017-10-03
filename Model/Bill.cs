using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Bill
    {
            public int BillNo {get;set;}
            public int DischargeId{get;set;}
            public int Hid{get;set;}
            public int WardCharge{get;set;}
            public int ConsultationCharge{get;set;}
            public int Tax{get;set;}
            public int Total{get;set;}
        public Appointment AppointmentDetails = new Appointment();
        public Wards WardDetails = new Wards();


            
    }
}
