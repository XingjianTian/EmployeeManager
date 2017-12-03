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
public partial class WebFiles_Employee_Add_employee : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.tb_birth.Attributes.Add("onfocus", "javascript:calendar()");
            Image1.ImageUrl = "~/WebFiles/Images/" + picurl.SelectedValue + ".jpg";
        }
    }


    protected void add_Click(object sender, EventArgs e)
    {
        if (tb_id.Text.Trim() == "")
        {
            Response.Write("<script>alert('员工编号不能为空')</script>");
            return;
        }
        //if (tb_name.Text.Trim() == "")
       // {
        //    Response.Write("<script>alert('员工姓名不能为空')</script>");
        //    return;
      //  }
        if (tb_birth.Text.Trim() == "")
        {
            Response.Write("<script>alert('出生年月不能为空')</script>");
            return;
        }

        if (tb_tel.Text.Trim() == "")
        {
            Response.Write("<script>alert('联系电话不能为空')</script>");
            return;
        }
        if (tb_address.Text.Trim() == "")
        {
            Response.Write("<script>alert('联系地址不能为空')</script>");
            return;
        }
        if (tb_region.Text.Trim() == "")
        {
            Response.Write("<script>alert('民族不能为空')</script>");
            return;
        }
        if (tb_political.Text.Trim() == "")
        {
            Response.Write("<script>alert('政治面貌不能为空')</script>");
            return;
        }
        if (tb_educated.Text.Trim() == "")
        {
            Response.Write("<script>alert('文化程度不能为空')</script>");
            return;
        }
        if (tb_marriage.Text.Trim() == "")
        {
            Response.Write("<script>alert('婚姻状况不能为空')</script>");
            return;
        }
        if (tb_idnumber.Text.Trim() == "")
        {
            Response.Write("<script>alert('身份证号不能为空')</script>");
            return;
        }
        if (tb_nativeplace.Text.Trim() == "")
        {
            Response.Write("<script>alert('籍贯不能为空')</script>");
            return;
        }
        if (tb_docloc.Text.Trim() == "")
        {
            Response.Write("<script>alert('档案所在地不能为空')</script>");
            return;
        }
        if (tb_domicileplace.Text.Trim() == "")
        {
            Response.Write("<script>alert('户口所在地不能为空')</script>");
            return;
        }
        if (tb_worknumber.Text.Trim() == "")
        {
            Response.Write("<script>alert('工作证号不能为空')</script>");
            return;
        }
        if (tb_workas.Text.Trim() == "")
        {
            Response.Write("<script>alert('职务不能为空')</script>");
            return;
        }
        if (tb_hiredate.Text.Trim() == "")
        {
            Response.Write("<script>alert('入职日期不能为空')</script>");
            return;
        }
        if (tb_upperenum.Text.Trim() == "")
        {
            Response.Write("<script>alert('上级员工编号不能为空')</script>");
            return;
        }
        if (tb_state.Text.Trim() == "")
        {
            Response.Write("<script>alert('员工状态不能为空')</script>");
            return;
        }
        if (tb_did.Text.Trim() == "")
        {
            Response.Write("<script>alert('部门编号不能为空')</script>");
            return;
        }
        Employ Registor = new Employ();
        string pic= "~/WebFiles/Images/" + picurl.SelectedValue + ".jpg";
        Registor.Insert(tb_id.Text.Trim(),tb_name.Text.Trim(),sex.SelectedValue,tb_birth.Text.Trim(),tb_tel.Text.Trim(),tb_address.Text.Trim(), pic,tb_region.Text.Trim(), tb_political.Text.Trim(), tb_educated.Text.Trim(), tb_marriage.Text.Trim(), tb_idnumber.Text.Trim(), tb_nativeplace.Text.Trim(), tb_docloc.Text.Trim(), tb_domicileplace.Text.Trim(), tb_worknumber.Text.Trim(), tb_workas.Text.Trim(), tb_hiredate.Text.Trim(), tb_upperenum.Text.Trim(), tb_state.Text.Trim(), tb_did.Text.Trim());
        Response.Redirect("~/WebFiles/Employee/List_employee.aspx");
    }
   
    protected void cancel_Click(object sender, EventArgs e)
    {
        tb_id.Text = "";
        tb_name.Text = "";
        tb_birth.Text = "";
        tb_tel.Text= "";
        tb_address.Text = "";
        tb_region.Text = "";
        tb_political.Text = "";
        tb_educated.Text = "";
        tb_marriage.Text = "";
        tb_idnumber.Text = "";
        tb_nativeplace.Text = "";
        tb_docloc.Text = "";
        tb_domicileplace.Text = "";
        tb_worknumber.Text = "";
        tb_workas.Text = "";
        tb_upperenum.Text = "";
        tb_state.Text = "";
        tb_did.Text = "";
        tb_hiredate.Text = "";
    }

    protected void picurl_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        Image1.ImageUrl = "~/WebFiles/Images/" + picurl.SelectedValue + ".jpg";
    }
}
