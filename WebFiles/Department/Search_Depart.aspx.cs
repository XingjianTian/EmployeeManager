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
public partial class WebFiles_Department_Search_Depart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void brn_search_Click(object sender, EventArgs e)
    {
        if (role.SelectedValue == "部门编号")
        {
            if (TxtContent.Text.Trim() == "")
            {
                Response.Write("<script>alert('部门编号不能为空!')</script>");
            }
            else
            {
                string sql = "select D_ID 部门编号,D_Name 部门名称,D_Belong 上级部门 from [Tb_department] where [D_ID]='" + TxtContent.Text.Trim() + "'";
                user Search = new user();
                SqlDataReader myreader = Search.Login(sql);
                List_employee.DataSource = myreader;
                List_employee.DataBind();
            }
        }
        else if (role.SelectedValue == "部门名称")
        {
            if (TxtContent.Text.Trim() == "")
            {
                Response.Write("<script>alert('部门名称不能为空!')</script>");
            }
            else
            {
                string sql = "select D_ID 部门编号,D_Name 部门名称,D_Belong 上级部门 from [Tb_department] where [D_Name]='" + TxtContent.Text.Trim() + "'";
                user Search = new user();
                SqlDataReader myreader = Search.Login(sql);
                List_employee.DataSource = myreader;
                List_employee.DataBind();
            }
        }
        else
        {
           
            string sql = "select D_ID 部门编号,D_Name 部门名称,D_Belong 上级部门 from [Tb_department] where [D_Chief]='" + TxtContent.Text.Trim() + "'";
            user Search = new  user();
            SqlDataReader myreader = Search.Login(sql);
            List_employee.DataSource = myreader;
            List_employee.DataBind();
           
        }
    }
}
