using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1.q3b
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user1\Source\Repos\VCCB2\WebApplication1\WebApplication1\App_Data\s_l.mdf;Integrated Security=True");
            SqlCommand cmd= new SqlCommand("select * from login",con);
            
            string uname=TextBox1.Text;
            string pwd=TextBox2.Text;

            con.Open();

            SqlDataReader rdr=cmd.ExecuteReader();
            if(uname==rdr["username"] && pwd==rdr["password"])
            {
                Session["username"]=uname;

            }
            
           Response.Redirect("home.aspx");
        }
    }
}