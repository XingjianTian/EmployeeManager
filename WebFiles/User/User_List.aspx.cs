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

public partial class WebFiles_User_User_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            Bind();
    }
    private void Bind()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Mispersonalconn"].ConnectionString);
        string sql = "select ID 用户编号,userName 用户姓名,userRole 用户角色 from [Tb_User_Login]";
        SqlDataAdapter sda = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        sda.Fill(ds, "temp");
        con.Close();
        List.DataSource = ds.Tables["temp"].DefaultView;
        List.DataBind();
    }

    protected void List_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        List.PageIndex= e.NewPageIndex;
        DataBind();
    }
}
