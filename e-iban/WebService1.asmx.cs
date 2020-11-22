using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace e_iban
{
    /// <summary>
    /// WebService1 için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

      
        [WebMethod]
        public DataSet IbanBul(string iban)
        {
            DataSet veri = new DataSet();
            SqlConnection connection = new SqlConnection(@"Data Source=31.210.159.41\SQLEXPRESS;Initial Catalog=banksube;Persist Security Info=True;User ID=asli;Password=As164020.");
            string banka_kodu = iban.Substring(2, 9);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select BankaSubeAdi From kodlar where BankaSubeKodu like'" + banka_kodu + "%'", connection);
            dataAdapter.Fill(veri);
            return veri;

        }
    }
}
