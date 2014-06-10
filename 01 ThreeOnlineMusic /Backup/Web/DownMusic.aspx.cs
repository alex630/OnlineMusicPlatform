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

public partial class DownMusic : System.Web.UI.Page
{
    public string MusicFilePath;
    public string MusicFileName;
    public int i;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Id"] == null)
        {
            Response.Redirect("Default.aspx");
        }

        if (!IsPostBack)
        {
            i = Convert.ToInt32(Request.QueryString["Id"]);
            
            BindMusic();
        }

    }


    public void BindMusic()
    {

        //int i = Convert.ToInt32(Request["Id"]);
        BLL.T_Music ManagerBll = new BLL.T_Music();

        if (ManagerBll.select((int)i).Tables[0].Rows.Count > 0)
        {
            // mediaPlayer.DataSource = ManagerBll.select1((int)i);
            //this.GV.DataSource = ManagerBll.select1((int)i);
            //this.GV.DataBind();
            MusicFilePath = ManagerBll.select((int)i).Tables[0].Rows[0][2].ToString();
            MusicFileName = ManagerBll.select((int)i).Tables[0].Rows[0][1].ToString();
            M_FileName.Text = MusicFileName;


        }

        //绑定最新歌曲
        if (ManagerBll.Select1().Tables[0].Rows.Count > 0)
        {
            this.GV5.DataSource = ManagerBll.Select1();
            this.GV5.DataBind();
        }



    }

    protected void GV5_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
