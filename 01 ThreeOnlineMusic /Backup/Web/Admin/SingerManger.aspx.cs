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


using BLL;


public partial class Admin_SingerManger : System.Web.UI.Page
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

            SingerSex.Items.Add(new ListItem("未选择", "0"));
            SingerSex.Items.Add(new ListItem("男", "1"));
            SingerSex.Items.Add(new ListItem("女", "2"));

            Update.Visible = false;

            //GVSinger绑定数据
            BindDate();
        }
    }


    #region 增加
    //添加按钮，增加数据
    protected void Add_Click(object sender, EventArgs e)
    {


        Model.T_Singer singer = new Model.T_Singer();

        singer.Name = SingerName.Text.Trim();
        singer.Sex = SingerSex.SelectedItem.ToString();


        BLL.T_Singer SingerBll = new BLL.T_Singer();


        if (SingerBll.Add(singer))
        {
            Response.Write("保存成功");

            BindDate();
        }
        else
        {
            Response.Write("保存失败");
        }
    }
    #endregion 增加

    //GVSinger分页
    protected void GVSinger_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        BLL.T_Singer SingerBll = new BLL.T_Singer();
        this.GVSinger.PageIndex = e.NewPageIndex;
        this.GVSinger.DataSource = SingerBll.select();//调用绑定的具体方法 
        this.GVSinger.DataBind();

    }


    //自定义函数，绑定GVSinger数据
    private void BindDate()
    {
        BLL.T_Singer SingerBll = new BLL.T_Singer();

        if (SingerBll.select().Tables[0].Rows.Count > 0)
        {
            this.GVSinger.DataSource = SingerBll.select();
            this.GVSinger.DataBind();
        }
        else
        {
            Response.Write("没有数据");
        }

    }




    protected void GVSinger_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        BLL.T_Singer SingerBll = new T_Singer();

        if (SingerBll.Select(Convert.ToInt32(GVSinger.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows.Count > 0)
        {
            S_Id.Value = SingerBll.Select(Convert.ToInt32(GVSinger.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][0].ToString();
            SingerName.Text = SingerBll.Select(Convert.ToInt32(GVSinger.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][1].ToString();
            //SingerSex.SelectedValue = SingerBll.Select(Convert.ToInt32(GVSinger.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][2].ToString();
            Add.Visible = false;
            Update.Visible = true;
        }
        else
        {
            Response.Write("没有数据");
        }
    }



    protected void Update_Click(object sender, EventArgs e)
    {
        Model.T_Singer Singer = new Model.T_Singer();

        Singer.Id = Convert.ToInt32(S_Id.Value);
        Singer.Name = SingerName.Text.Trim();
        Singer.Sex = SingerSex.SelectedItem.ToString();
        //Singer.ClassNO = ddlClass.SelectedValue.ToString();

        BLL.T_Singer SingerBll = new BLL.T_Singer();


        if (SingerBll.Update(Singer))
        {
            Response.Write("修改成功");
            Add.Visible = true;
            Update.Visible = false;

            BindDate();
        }
        else
        {
            Response.Write("修改失败");
        }
    }


    protected void GVSinger_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        Model.T_Singer Singer = new Model.T_Singer();
        BLL.T_Singer SingerBll = new T_Singer();

        //Singer.Id = Convert.ToInt32(GVSinger.Rows[e.RowIndex].Cells[0].Text);
        Singer.Id = Convert.ToInt32(SingerBll.Select(Convert.ToInt32(GVSinger.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][0].ToString());


        if (SingerBll.Delete(Singer))
        {
            Response.Write("删除成功");
            BindDate();
        }
        else
        {
            Response.Write("删除失败");
        }

    }

}
