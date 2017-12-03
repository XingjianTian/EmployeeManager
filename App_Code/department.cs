using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public class department
{
		//常用的对象
        private string connstr;
        private SqlConnection Sqlconn;
        private SqlCommand Sqlcmd;
        private SqlDataAdapter Sqladpter;
        private DataSet ds;
        private SqlDataReader Sqlreader;

	public department()
	{//初始化所有的实例
            connstr = ConfigurationManager.ConnectionStrings["Mispersonalconn"].ConnectionString;
            Sqlconn = new SqlConnection(connstr);
            Sqlcmd = new SqlCommand();
            Sqladpter = new SqlDataAdapter();
            ds = new DataSet();
	}

    public SqlDataReader Login(string sql)
    {
        Sqlcmd.CommandText = sql;
        Sqlcmd.Connection = Sqlconn;
        if (Sqlconn.State == ConnectionState.Closed) { Sqlconn.Open(); }
        Sqlreader = Sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
        return Sqlreader;
    }

    public void Insert(string D_ID, string D_Name, string D_Belong)
    {//执行添加动作   (E_ID,E_Name,E_Sex,E_Birth,E_Tel,E_Address) 
        Sqlcmd.CommandText = "insert into [Tb_department] values('" + D_ID + "','" + D_Name + "','"+ D_Belong + "')";
        //Sqlcmd.Parameters.AddWithValue("@e_id", E_ID);
        //Sqlcmd.Parameters.AddWithValue("@e_name",E_Name);
        //Sqlcmd.Parameters.AddWithValue("@e_sex",E_Sex);
        //Sqlcmd.Parameters.AddWithValue("@e_birth",E_Birth);
        //Sqlcmd.Parameters.AddWithValue("@e_tel",E_Tel);
        //Sqlcmd.Parameters.AddWithValue("@e_address",E_Address);
        //Sqlcmd.Parameters.AddWithValue("@e_intro",E_Intro);
        //Sqlcmd.Parameters.AddWithValue("@e_picurl",E_Picurl);
        Sqlcmd.Connection = Sqlconn;
        Sqlconn.Open();
        Sqlcmd.ExecuteNonQuery();
    }
}
