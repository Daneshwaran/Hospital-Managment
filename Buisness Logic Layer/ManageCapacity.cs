using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Buisness_Logic_Layer;
using DAO;
using Model;

namespace Buisness_Logic_Layer
{
    public class ManageCapacity
    {
        public DataSet Getds()
        {
            DAO.ManageCapacity mm = new DAO.ManageCapacity();
            return mm.Getdataset();
        }
        public DataSet Geetdsdischarge()
        {
            DAO.ManageCapacity bbn = new DAO.ManageCapacity();
            return bbn.Getdatadis();
        }

        public void AddAdmit(Admit a)
        {
            DAO.ManageCapacity ha = new DAO.ManageCapacity();
            ha.AddAdmit(a);
        }
        public int Progressb()
        {
            DAO.ManageCapacity oo = new DAO.ManageCapacity();
            return oo.PrograssBar();
        }
    }
}
