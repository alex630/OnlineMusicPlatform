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
//|来|自|5|1|a|s|p|x
public partial class _Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        // 绑定歌曲, 歌手
        BLL.T_Music ManagerBll = new BLL.T_Music();
        
        if (ManagerBll.select1((int)5).Tables[0].Rows.Count > 0)
        {
            this.GV1.DataSource = ManagerBll.select1((int)5);
            this.GV1.DataBind();
        }

        if (ManagerBll.select1((int)8).Tables[0].Rows.Count > 0)
        {
            this.GV2.DataSource = ManagerBll.select1((int)8);
            this.GV2.DataBind();
        }

        if (ManagerBll.select1((int)9).Tables[0].Rows.Count > 0)
        {
            this.GV3.DataSource = ManagerBll.select1((int)9);
            this.GV3.DataBind();
        }

        if (ManagerBll.select1((int)4).Tables[0].Rows.Count > 0)
        {
            this.GV4.DataSource = ManagerBll.select1((int)4);
            this.GV4.DataBind();
        }

        if (ManagerBll.Select1().Tables[0].Rows.Count > 0)
        {
            this.GV5.DataSource = ManagerBll.Select1();
            this.GV5.DataBind();
        }



    }
}
