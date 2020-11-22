using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace e_iban
{
    public partial class anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        { e_iban.ServiceReference1.WebService1SoapClient istemci = new ServiceReference1.WebService1SoapClient();
            DataSet gelen = istemci.IbanBul(TextBox1.Text);
            if (gelen.Tables[0].Rows.Count > 0)
            {
                Label1.Text = gelen.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                Label1.Text = "Bulunamadı";
            }

        }
    }
}