using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Buisness_Logic_Layer;
using Model;

namespace Hospital_Managment
{
    public partial class ManageCapacity : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MAIT-ATOS-250\SQLEXPRESS;Initial Catalog=karthik;Persist Security Info=True;User ID=SA;Password=Atos@1");
            Buisness_Logic_Layer.ManageCapacity mc = new Buisness_Logic_Layer.ManageCapacity();
            int i = mc.Progressb();
            
            if (!IsPostBack)
            {

                DataSet ds = mc.Getds();
                Repeater1.DataSource = ds;
                Repeater1.DataBind();
                DataSet dsdis = mc.Geetdsdischarge();
                Repeater2.DataSource = dsdis;
                Repeater2.DataBind();
               // HiddenField.value = mc.Progressb();

            }
        }
    }
}