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

public partial class RockMusic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindMusic();
        }
    }
    public void BindMusic()
    {
        BLL.T_Music ManagerBll = new BLL.T_Music();

        if (ManagerBll.select3((int)8).Tables[0].Rows.Count > 0)
        {
            this.GV1.DataSource = ManagerBll.select3((int)8);
            this.GV1.DataBind();
        }

        if (ManagerBll.Select2().Tables[0].Rows.Count > 0)
        {
            this.GV5.DataSource = ManagerBll.Select2();
            this.GV5.DataBind();
        }

    }

    protected void GV1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        BLL.T_Music MusicBll = new BLL.T_Music();
        this.GV1.PageIndex = e.NewPageIndex;
        this.GV1.DataSource = MusicBll.select3((int)8);//调用绑定的具体方法 
        this.GV1.DataBind();
    }
}
