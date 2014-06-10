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


using Model;
using BLL;

public partial class Admin_Manager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string Adminuser = string.Empty;
        if (Session["username"] == null)
        {
            Adminuser = "";
        }
        else
        {
            Adminuser = Session["username"].ToString();
        }
        if (Adminuser == "")
        {
            Response.Redirect("Login.aspx");
        }
        if (!IsPostBack)
        {
        BindDate();
        }
        Label1.Visible = false;
        OldPWD.Visible = false;
        UpDate.Visible = false;

       
    }


    //自定义函数，绑定GVSinger数据
    private void BindDate()
    {
        BLL.T_Manager ManagerBll = new BLL.T_Manager();

        if (ManagerBll.select().Tables[0].Rows.Count > 0)
        {
            this.GVManager.DataSource = ManagerBll.select();
            this.GVManager.DataBind();
        }
        else
        {
            Response.Write("没有数据");
        }

    }
    //修改密码
    protected void GVManager_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        BLL.T_Manager ManagerBll = new BLL.T_Manager();

        if (ManagerBll.Select(Convert.ToInt32(GVManager.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows.Count > 0)
        {
            //获取数据Id并放在一个控件中
            S_Id.Value = ManagerBll.Select(Convert.ToInt32(GVManager.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][0].ToString();
            U_Name.Text = ManagerBll.Select(Convert.ToInt32(GVManager.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][1].ToString();
            //SingerSex.SelectedValue = SingerBll.Select(Convert.ToInt32(GVSinger.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][2].ToString();
            // Add.Visible = false;
            // Update.Visible = true;
            //Label1.Visible = true;
            //OldPWD.Visible = true;
            Add.Visible = false;
            UpDate.Visible = true;
        }
        else
        {
            Response.Write("没有数据");
        }

    }



    //确定修改密码
    protected void UpDate_Click(object sender, EventArgs e)
    {

        //输入数据存入Model
        Model.T_Manager Manager = new Model.T_Manager();

        Manager.Id = Convert.ToInt32(S_Id.Value);
        Manager.UserName = U_Name.Text.Trim();
        Manager.PassWord = NewPWD2.Text.Trim();
        //Singer.ClassNO = ddlClass.SelectedValue.ToString();

        BLL.T_Manager ManagerBll = new BLL.T_Manager();


        if (ManagerBll.Update(Manager))
        {
            Response.Write("修改成功");
            Add.Visible = true;
            UpDate.Visible = false;

            BindDate();
        }
        else
        {
            Response.Write("修改失败");
        }

    }


    protected void GVManager_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        Model.T_Manager model = new Model.T_Manager();
        BLL.T_Manager ManagerBll = new BLL.T_Manager();

        model.Id = Convert.ToInt32(ManagerBll.Select(Convert.ToInt32(GVManager.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][0].ToString());


        if (ManagerBll.Delete(model.Id))
        {
            Response.Write("删除成功");
            BindDate();
        }
        else
        {
            Response.Write("删除失败");
        }


    }
    protected void Add_Click(object sender, EventArgs e)
    {

            Model.T_Manager Manager = new Model.T_Manager();

            Manager.UserName = U_Name.Text.Trim();
            Manager.PassWord = NewPWD2.Text.Trim();

            BLL.T_Manager ManagerBll = new BLL.T_Manager();
            if (ManagerBll.Add(Manager))
            {
                //上传成功，给出提示
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), Guid.NewGuid().ToString(), "alert('添加成功')", true);
                BindDate();
                //Response.Write("<script><alert>上传成功</alert></script>");
                Response.Redirect("Manager.aspx");

            }
        
    }
}
