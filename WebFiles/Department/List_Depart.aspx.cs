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
public partial class WebFiles_Department_List_Depart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
         Bind();
    }
    private void Bind()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mispersonalconn"].ConnectionString);
        string sql = "select D_ID 部门编号,D_Name 部门名称,D_Belong 上级部门 from [Tb_department]";
        SqlDataAdapter sda = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        sda.Fill(ds, "temp");
        con.Close();
        ListDepart.DataSource = ds.Tables["temp"].DefaultView;
        ListDepart.DataBind();
    }

    protected void ListDepart_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        ListDepart.PageIndex = e.NewPageIndex;
        DataBind();

    }

   
}
