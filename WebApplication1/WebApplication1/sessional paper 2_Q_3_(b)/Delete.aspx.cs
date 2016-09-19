using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
namespace WebApplication1.sessional_paper_2_Q_3__b_
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user1\Source\Repos\VCCB22\WebApplication1\WebApplication1\App_Data\Q_3(b)_Student_Result.mdf;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand("select sti_id from student_result", con);
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    DropDownList1.Items.Add("" + rdr["sti_id"] + "");
                }
                rdr.Close();
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user1\Source\Repos\VCCB22\WebApplication1\WebApplication1\App_Data\Q_3(b)_Student_Result.mdf;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("delete from student_result  where sti_id='" + DropDownList1.SelectedItem.Text + "'", con);
            SqlDataReader rdr;
            rdr = com.ExecuteReader();
//l1.Text = com.ExecuteNonQuery().ToString();
            rdr.Close();
            con.Close();
        
        }
    }
}