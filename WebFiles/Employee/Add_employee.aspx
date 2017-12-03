<%@ Page Language="C#" CodePage="936" AutoEventWireup="true"  EnableEventValidation="false" CodeFile="Add_employee.aspx.cs" Inherits="WebFiles_Employee_Add_employee" %>
<%@ Register Src="../../UserControl/Left_Navlist.ascx" TagName="Left_Navlist" TagPrefix="uc3" %>
<%@ Register Src="../../UserControl/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加员工信息</title>
    <link rel=Stylesheet type="text/css" href="../../CSS/Mispersonal.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Header ID="Header1" runat="server" />
        &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <div style="z-index: 101; left: 230px; width: 531px; position: absolute; top: 225px;
            height: 212px">
            <table cellpadding="0" cellspacing="0" align="center" style="width: 550px" id="TABLE1" runat="server">
                <tr>
                    <td colspan="3" style="height: 21px" bgcolor="#66c2de" align="center">
                        添加员工信息</td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;员工编号:</td>
                    <td style="width: 201px; height: 35px;">
        <asp:TextBox ID="tb_id" runat="server"></asp:TextBox></td>
                    <td style="width: 177px; height: 35px;">
                    </td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;员工姓名:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_name" runat="server"></asp:TextBox></td>
                    <td style="width: 177px; height: 35px;">
                    </td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;员工性别:</td>
                    <td style="width: 201px; height: 35px;">
                    <asp:DropDownList ID="sex" runat="server">
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
        </asp:DropDownList></td>
                    <td style="width: 177px; height: 35px;">
                    </td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;出生年月:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_birth" runat="server"></asp:TextBox></td>
                    <td style="width: 177px;" rowspan="4" align="center">
                        &nbsp; &nbsp; &nbsp;&nbsp;
                        <asp:Image ID="Image1" runat="server" Height="108px" Width="123px" /></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;联系电话:</td>
                    <td style="width: 201px; height: 35px;">
        <asp:TextBox ID="tb_tel" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;联系地址:</td>
                    <td style="width: 201px; height: 35px;">
        <asp:TextBox ID="tb_address" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;照片:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:DropDownList ID="picurl" runat="server" OnSelectedIndexChanged="picurl_SelectedIndexChanged"  AutoPostBack="True">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;民族:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_region" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;政治面貌:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_political" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;文化程度:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_educated" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;婚姻状况:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_marriage" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;身份证号:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_idnumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;籍贯:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_nativeplace" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;档案所在地:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_docloc" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;户口所在地:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_domicileplace" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;工作证号:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_worknumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;入职日期:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_hiredate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;职务:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_workas" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;上级职员编号:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_upperenum" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;员工状态:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_state" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 363px; height: 35px;">
                        &nbsp;所在部门编号:</td>
                    <td style="width: 201px; height: 35px;">
                        <asp:TextBox ID="tb_did" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="3" style="height: 35px">
                        &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="add" runat="server" Text="添加" OnClick="add_Click" />
                        &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        &nbsp; &nbsp; &nbsp;<asp:Button ID="cancel" runat="server" Text="重置" OnClick="cancel_Click" /></td>
                </tr>
            </table>
        </div>
        <uc3:Left_Navlist ID="Left_Navlist1" runat="server" />
    
    </div>
    </form>
</body>
</html>
