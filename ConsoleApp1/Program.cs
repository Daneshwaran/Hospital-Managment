using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            System.Console.Write("HID      :");
            p.HID = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("FirstName:");
            p.FirstName = Convert.ToString(System.Console.ReadLine());
            System.Console.Write("LastName :");
            p.LastName = Convert.ToString(System.Console.ReadLine());
            System.Console.Write("Date     :");
            p.Date = Convert.ToString(System.Console.ReadLine());
            System.Console.Write("Gender   :");
            p.Gender = Convert.ToString(System.Console.ReadLine());
            System.Console.Write("DateOfBirth:");
            p.DateOfBirth = Convert.ToString(System.Console.ReadLine());
            System.Console.Write("BloodGroup :");
            p.BloodGroup = Convert.ToString(System.Console.ReadLine());
            System.Console.Write("Address    :");
            p.Address = Convert.ToString(System.Console.ReadLine());
            System.Console.Write("Mobile     :");
            p.Mobile = Convert.ToString(System.Console.ReadLine());
            System.Console.Write("EmailID    :");
            p.EmailID = Convert.ToString(System.Console.ReadLine());
            System.Console.Write("Password   :");
            p.Password = Convert.ToString(System.Console.ReadLine());

            Buisness_Logic_Layer.BuisnessLL ll = new Buisness_Logic_Layer.BuisnessLL();
            //ll.SavePatient(p);

            Program po = new Program();
                po.Display_all(ll.Patients());
        }

        public void Display_all(List<Patient> pp)
        {
            foreach (Patient pat in pp)
                Display(pat);
        }
        public void Display(Patient pt)
        {
            Console.Write(pt.HID + "  ");
            Console.Write(pt.FirstName + "  ");
            Console.Write(pt.LastName + "  ");
            Console.Write(pt.Date + "  ");
            Console.Write(pt.Gender + "  ");
            Console.Write(pt.DateOfBirth + "  ");
            Console.Write(pt.BloodGroup + "  ");
            Console.Write(pt.Address + "  ");
            Console.Write(pt.Mobile + "  ");
            Console.Write(pt.EmailID + "  ");
            Console.WriteLine(pt.Password + "  ");
        }
    }
}
