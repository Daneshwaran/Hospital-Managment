using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model
{
   public class Doctor
    {
        
        public int Doctor_ID { get; set; }
        public int Department_ID { get; set; }
        public string Name { get; set; }
        public string Date_Of_Birth { get; set; }
        public string Gender { get; set; }
        public string Degree { get; set; }
        public string Blood_Group { get; set; }
        public string Address { get; set; }
        public int Mobile { get; set; }
        public string Password { get; set; }
        public string Date_Of_Joining { get; set; }
        public string Specialization { get; set; }
        public string City { get; set; }
        public string EmailID { get; set; }
        
    }
}
