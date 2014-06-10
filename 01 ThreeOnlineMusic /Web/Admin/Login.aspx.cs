using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Admin_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void clean_Click(object sender, ImageClickEventArgs e)
    {
        username.Text = "";
        password.Text = "";
    }
    protected void login_Click(object sender, ImageClickEventArgs e)
    {
      
        Model.T_Manager model = new Model.T_Manager();
        model.UserName = username.Text;
        model.PassWord = password.Text;


        BLL.T_Manager Login = new BLL.T_Manager();
        if (Login.select(model))
        {
            Session.Add("username",model.UserName);
            Response.Redirect("Default.aspx");
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "User name and password don't match";
            
        }
    }
}
