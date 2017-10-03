
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Patient
    {
        public int HID { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public string Date { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        
       // public Bill BillDetails = new Bill();
    }
}
