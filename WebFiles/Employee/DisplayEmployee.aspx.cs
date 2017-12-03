using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class WebFiles_Employee_DisplayEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request["E_ID"];
            string name = Request["E_Name"];
            Session["E_ID"] = id;
            Session["E_Name"] = name;
            Bond();

            string connstr = ConfigurationManager.ConnectionStrings["Mispersonalconn"].ConnectionString;
            SqlConnection Sqlconn = new SqlConnection(connstr);
            DataSet ds = new DataSet();
            string Agreerstr = "select D_ID,D_Name from Tb_department order by D_ID desc";
            SqlDataAdapter SqlAgreer = new SqlDataAdapter(Agreerstr, Sqlconn);
            SqlAgreer.Fill(ds, "Agreer");
            Agreer.DataSource = ds.Tables["Agreer"].DefaultView;
            Agreer.DataTextField = "D_Name";
            Agreer.DataValueField = "D_ID";
            Agreer.DataBind();
            Sqlconn.Close();
        }
    }
    private void Bond()
    {
        string id = (string)Session["E_ID"];
        string sql = "select * from [Tb_employee] where E_ID='" + id + "'";
        string connstr = ConfigurationManager.ConnectionStrings["Mispersonalconn"].ConnectionString;
        SqlConnection Sqlconn = new SqlConnection(connstr);
        Sqlconn.Open();
        SqlCommand sc = new SqlCommand(sql, Sqlconn);
        SqlDataReader myreader = sc.ExecuteReader();
        if(myreader.Read())
        {
            TxtID.Text = myreader[0].ToString();
            TxtName.Text = myreader[1].ToString();
            TxtBirth.Text = myreader[3].ToString();
            TxtTel.Text = myreader[4].ToString();
            TxtAddress.Text = myreader[5].ToString();
            Pic.ImageUrl = myreader[6].ToString();
            TxtRegion.Text = myreader[7].ToString();
            TxtPolitical.Text = myreader[8].ToString();
            TxtEducated.Text = myreader[9].ToString();
            TxtMarriage.Text = myreader[10].ToString();
            TxtIdnumber.Text = myreader[11].ToString();
            TxtNativeplace.Text = myreader[12].ToString();
            TxtDocloc.Text = myreader[13].ToString();
            TxtDomicileplace.Text = myreader[14].ToString();
            TxtWorknumber.Text = myreader[15].ToString();
            TxtHiredate.Text = myreader[16].ToString();
            TxtWorkas.Text = myreader[17].ToString();
            TxtUpperenum.Text = myreader[18].ToString();
            TxtState.Text = myreader[19].ToString();
            TxtDid.Text = myreader[20].ToString();
            Sqlconn.Close();
        }
    }
    protected void btn_edit_Click(object sender, EventArgs e)
    {
        if ((string)Session["Name"] != "")
        {
            if ((string)Session["role"] == "1")
            {
                string id = (string)Session["E_ID"];
                string sql = "update [Tb_employee] set E_Name='"
                             + TxtName.Text.Trim() + "',E_Sex='"
                             + Sex.SelectedValue + "',E_Birth='"
                             + TxtBirth.Text + "',E_Tel='"
                             + TxtTel.Text.Trim() + "',E_Address='"
                             + TxtAddress.Text.Trim() + "',E_Picurl='"
                             + picurl.SelectedValue + "',E_Region='"
                             + TxtRegion.Text.Trim() + "',E_Political='"
                             + TxtPolitical.Text.Trim() + "',E_Educated='"
                             + TxtEducated.Text.Trim() + "',E_Marriage='"
                             + TxtMarriage.Text.Trim() + "',E_IDNumber='"
                             + TxtIdnumber.Text.Trim() + "',E_NativePlace='"
                             + TxtNativeplace.Text.Trim() + "',E_DocLoc='"
                             + TxtDocloc.Text.Trim() + "',E_DomicilePlace='"
                             + TxtDomicileplace.Text.Trim() + "',D_WorkNumbr='"
                             + TxtWorknumber.Text.Trim() + "',D_HireDate='"
                             + TxtHiredate.Text.Trim() + "',D_WorkAs='"
                             + TxtWorkas.Text.Trim() + "',D_UpperENUM='"
                             + TxtUpperenum.Text.Trim() + "',D_State='"
                             + TxtState.Text.Trim() + "',D_ID='"
                             + TxtDid.Text.Trim()
                 + "'"+"where E_ID='"
                 +TxtID.Text.Trim()+ "'";
                string connstr = ConfigurationManager.ConnectionStrings["Mispersonalconn"].ConnectionString;
                SqlConnection Sqlconn = new SqlConnection(connstr);
                Sqlconn.Open();
                SqlCommand sc = new SqlCommand(sql, Sqlconn);
                sc.ExecuteNonQuery();
                lbMessage.Text = "您已成功更新1条记录!";
                Sqlconn.Close();
            } 
            else
            {
                Response.Write("<script>alert('只有管理员才可以进行此操作!')</script>");
            }
        }
        else
        {
            Response.Redirect("Default.aspx"); ;
        }

    }

    protected void btn_delete_Click(object sender, EventArgs e)
    {
        if ((string)Session["Name"] != "")
        {
            if ((string)Session["role"] == "1")
            {
                string id = (string)Session["E_ID"];
                string sql = "delete from [Tb_employee] where E_ID='" + id + "'";
                string connstr = ConfigurationManager.ConnectionStrings["Mispersonalconn"].ConnectionString;
                SqlConnection Sqlconn = new SqlConnection(connstr);
                Sqlconn.Open();
                SqlCommand sc = new SqlCommand(sql, Sqlconn);
                sc.ExecuteNonQuery();
                Sqlconn.Close();
                Response.Redirect("~/WebFiles/Employee/List_employee.aspx");
            }

            else
            {
                Response.Write("<script>alert('只有管理员才可以进行此操作!')</script>");
            }
        }
        else
        {
            Response.Redirect("Default.aspx"); ;
        }
    }
}
