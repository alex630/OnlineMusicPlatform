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

public partial class Admin_MusicStyle : System.Web.UI.Page
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
    }
    //绑定数据函数
    private void BindDate()
    {
        BLL.T_Style StyleBll = new BLL.T_Style();

        if (StyleBll.select().Tables[0].Rows.Count > 0)
        {
            this.GV_Style.DataSource = StyleBll.select();
            this.GV_Style.DataBind();
        }
        else
        {
            Response.Write("NO DATA");
        }


        //没有点击修改时，更新按钮不可见
        Add.Visible = true;
        Update.Visible = false;

    }


    //点击修改按钮后把数据加载到文本框中便于修改
    protected void GV_Style_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        BLL.T_Style StyleBll = new BLL.T_Style();

        if (StyleBll.Select(Convert.ToInt32(GV_Style.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows.Count > 0)
        {
            //获取数据Id并放在一个控件中
            S_Id.Value = StyleBll.Select(Convert.ToInt32(GV_Style.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][0].ToString();
            TB_Style.Text = StyleBll.Select(Convert.ToInt32(GV_Style.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][1].ToString();
            //SingerSex.SelectedValue = SingerBll.Select(Convert.ToInt32(GVSinger.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][2].ToString();
            Add.Visible = false;
            Update.Visible = true;
        }
        else
        {
            Response.Write("NO DATA");
        }

    }

    //点击更新按钮更新数据
    protected void Update_Click(object sender, EventArgs e)
    {
        Model.T_Style Style = new Model.T_Style();

        Style.Id = Convert.ToInt32(S_Id.Value);
        Style.Style = TB_Style.Text.Trim();
        //Style.Sex = SingerSex.SelectedItem.ToString();
        //Singer.ClassNO = ddlClass.SelectedValue.ToString();

        BLL.T_Style StyleBll = new BLL.T_Style();


        if (StyleBll.Update(Style))
        {
            Response.Write("DONE");
            Add.Visible = true;
            Update.Visible = false;
            TB_Style.Text = "";

            BindDate();
        }
        else
        {
            Response.Write("FAILURE");
        }
    }

    //删除数据
    protected void GV_Style_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
       
        Model.T_Style Style = new Model.T_Style();
        BLL.T_Style SingerBll = new BLL.T_Style();
        //Singer.Id = Convert.ToInt32(GVSinger.Rows[e.RowIndex].Cells[0].Text);
        Style.Id = Convert.ToInt32(SingerBll.Select(Convert.ToInt32(GV_Style.Rows[e.RowIndex].Cells[0].Text)).Tables[0].Rows[0][0].ToString());


        if (SingerBll.Delete(Style))
        {
            Response.Write("DONE");
            BindDate();
        }
        else
        {
            Response.Write("FAILURE");
        }

    }

    //增加歌曲类型
    protected void Add_Click(object sender, EventArgs e)
    {
        //如果文本框为空，不保存
        if (TB_Style.Text == "")
        {
            Response.Write("FAILURE");
            
        }

        else
        {
            Model.T_Style Style = new Model.T_Style();
            Style.Style = TB_Style.Text.Trim();

            BLL.T_Style StyleBll = new BLL.T_Style();
            if (StyleBll.Add(Style))
            {
                Response.Write("DONE");

                BindDate();
            }
            else
            {
                Response.Write("FAILURE");
            }
        }

    }

}
