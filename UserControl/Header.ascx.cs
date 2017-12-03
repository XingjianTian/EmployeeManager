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

public partial class Control_WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbMessage.Text = "欢迎" + ((string)Session["role"] == "1"?"管理员":"普通用户") + (string)Session["name"] + "登陆本系统!";
    
    }
 
    
}
