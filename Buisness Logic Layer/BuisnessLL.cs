using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Buisness_Logic_Layer
{
    public class BuisnessLL
    {
        public void SavePatient(Patient p)
        {
          DAO.PatientDAO pd = new DAO.PatientDAO();
          pd.SavePatient(p);
        }

        public List<Patient> Patients()
        {
            DAO.PatientDAO p = new DAO.PatientDAO();
            return p.Patients();
        }
        
    }
}
