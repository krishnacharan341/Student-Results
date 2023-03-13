using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Student_Results
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible= false;
            if(!IsPostBack)
            {
                GetData();
            }
        }
        void GetData()
        {

            OracleConnection con = new OracleConnection("data source=ORCL_UAT;user id=COLLEGENEW;password=LOCAL");
            OracleDataAdapter da = new OracleDataAdapter("select * from RESULT", con);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("data source=ORCL_UAT;user id=COLLEGENEW;password=LOCAL");
            con.Open();
            int N=int.Parse(TextBox1.Text);
            int s1=int.Parse(TextBox3.Text);
            int s2=int.Parse(TextBox4.Text);
            int s3 =int.Parse(TextBox5.Text);   
            int s4 =    int.Parse(TextBox6.Text);
            int s5=int.Parse(TextBox7.Text);

            // int marks =TextBox3.Text + TextBox4.Text + TextBox5.Text + TextBox6.Text + TextBox7.Text;
            int Total = s1 + s2 + s3 + s4 + s5;
            string q = "insert into RESULT values('"+N+"','"+TextBox2.Text+ "','"+s1+"','"+s2+ "','"+s3+"','"+s4+"','"+s5+"','"+Total+"')";
               OracleCommand cmd=new OracleCommand(q,con);
            int i=cmd.ExecuteNonQuery();
            if (i == 1)
            {
                Label1.Text = "Record Inserted";
            }
            else
            {
                Label1.Text = "Not inserted";
            }
            Label1.Visible = true;
            con.Close();
            GetData();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            OracleConnection con = new OracleConnection("data source=ORCL_UAT;user id=COLLEGENEW;password=LOCAL");
            con.Open();
            int Rollnumber =int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string q = "delete from RESULT where ROLL='"+Rollnumber+"'";
            OracleCommand cmd= new OracleCommand(q,con);
            cmd.ExecuteNonQuery();
            
            GetData();
            con.Close();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GetData();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex=e.NewEditIndex;
            GetData();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GetData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            TextBox R =row.FindControl("TextBox2") as TextBox;
            TextBox N = row.FindControl("TextBox3") as TextBox;
            TextBox H = row.FindControl("TextBox4") as TextBox;
            TextBox E = row.FindControl("TextBox5") as TextBox;
            TextBox M = row.FindControl("TextBox6") as TextBox;
            TextBox P = row.FindControl("TextBox7") as TextBox;
            TextBox C = row.FindControl("TextBox8") as TextBox;
            //string s=R.Text;
            int rn=int.Parse(R.Text.ToString());
            string name = N.Text;
            int s1=Convert.ToInt32(H.Text);
            int s2=int.Parse(E.Text);
            int s3=int.Parse(M.Text);
            int s4=int.Parse(P.Text);
            int s5=int.Parse(C.Text);
            int marks=s1+s2+s3+s4+s5;
            OracleConnection con = new OracleConnection("data source=ORCL_UAT;user id=COLLEGENEW;password=LOCAL");
            con.Open();
            
            string q = "update RESULT set NAME='"+name+"',HIN='"+s1+"',ENG='"+s2+"',MATH='"+s3+"',PHY='"+s4+"',CHE='"+s5+"',TOTAL='"+marks+"' where ROLL='" + rn + "'";
            OracleCommand cmd = new OracleCommand(q, con);
            cmd.ExecuteNonQuery();
            GridView1.EditIndex = -1;
            GetData();
            con.Close();

        }
    }
}