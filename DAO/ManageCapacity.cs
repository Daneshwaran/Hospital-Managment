using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{

    public class ManageCapacity
    {
        SqlConnection con = new SqlConnection(@"Data Source=MAIT-ATOS-250\SQLEXPRESS;Initial Catalog=karthik;Persist Security Info=True;User ID=SA;Password=Atos@1");
        SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter adp;
        DataSet ds = null;
        public DataSet Getdataset()
        {
            adp = new SqlDataAdapter("select * from Admit2", con);
            ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet Getdatadis()
        {
            adp = new SqlDataAdapter("select * from Discharge", con);
            ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public void AddAdmit(Admit a)
        {
            con.Open();
            cmd = new SqlCommand("select MAX(*) from Discharge", con);
            int max = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            a.AdmitId = max + 1;
            try
            {
                SqlCommand com = new
                SqlCommand("insert into Discharge values('" + a.AdmitId + "','" + a.HospitalId + "','" + a.DoctorId + "','" + a.AdmitDate + "', '" + a.WardNumber + "')", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }


        public int PrograssBar()
        {
            con.Open();
            cmd = new SqlCommand("select count(*) from Admit2", con);
            int pb= Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return pb;
        }
    }
}
