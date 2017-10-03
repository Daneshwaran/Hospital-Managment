using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DAO

{
    public class PatientDAO
    {
        public void SavePatient(Patient p)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MAIT-ATOS-250\SQLEXPRESS;Initial Catalog=karthik;Persist Security Info=True;User ID=SA;Password=Atos@1");
                SqlCommand com = new
                SqlCommand("insert into Patient values('" + p.HID + "','" + p.FirstName + "','" + p.LastName + "', '" + p.Date + " ','" + p.DateOfBirth + "','" + p.Gender + "','" + p.BloodGroup + "','" + p.Address + "','" + p.Mobile + "','" + p.EmailID + "','" + p.Password + "')", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }
        public List<Patient> Patients()
        {
            List<Patient> List = new List<Patient>();
            SqlConnection con = new SqlConnection(@"Data Source=MAIT-ATOS-250\SQLEXPRESS;Initial Catalog=karthik;Persist Security Info=True;User ID=SA;Password=Atos@1");
            SqlCommand com = new SqlCommand("select * from Patient", con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Patient pp = new Patient
                {
                    HID = dr.GetInt32(0),
                    FirstName = dr.GetString(1),
                    LastName = dr.GetString(2),
                    Date = dr.GetString(3),
                    Gender = dr.GetString(4),
                    DateOfBirth = dr.GetString(5),
                    BloodGroup = dr.GetString(6),
                    Address = dr.GetString(7),
                    Mobile = dr.GetString(8),
                    EmailID = dr.GetString(9),
                    Password = dr.GetString(10)
                };
                List.Add(pp);
            }
            con.Close();
            return List;
        }

    }
}
