using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM
{
    internal class MainClass
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-066KIFU\\SQLEXPRESS;Initial Catalog=RM1;Integrated Security=True;Pooling=False; User ID=admin; Password=123;");
        //metodo para dar check ao username 
        public static bool IsValidUser(string user, string pass)
        {
           bool isValid = false;
           string qry = @"Select * from users where username = '" + user + "' and upass = '" + pass + "' ";
           SqlCommand cmd = new SqlCommand(qry, con);
           DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(dt);

           if(dt.Rows.Count >0)
            {
                isValid= true;
            }
            return isValid;
        }
    }
}
