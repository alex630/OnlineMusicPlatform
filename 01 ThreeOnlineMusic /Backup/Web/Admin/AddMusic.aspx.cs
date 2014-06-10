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

public partial class Admin_AddMusic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
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

            BindDate();
        }

    }
    public void BindDate()
    {
        //绑定歌曲类型到下拉文本框
        BLL.T_Style BllStyle = new T_Style();
        DropDownList1.DataSource = BllStyle.select().Tables[0];
        DropDownList1.DataTextField = "Style";
        DropDownList1.DataValueField = "Id";
        DropDownList1.DataBind();

        //绑定歌手姓名到下拉文本框
        BLL.T_Singer BllSinger = new T_Singer();
        DpDSinger.DataSource = BllSinger.select().Tables[0];
        DpDSinger.DataTextField = "Name";
        DpDSinger.DataValueField = "Id";
        DpDSinger.DataBind();





    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        UpLoad();
    }

    //上传歌曲
    private void UpLoad()
    {

        Boolean FileOK = false;
        Boolean MusicOK = true;
        //Boolean LyricOK = false;

        string Musicpath = Server.MapPath("~/File/Mp3/");
        string Lyricpath = Server.MapPath("~/File/Lyric/");
        if (UpLoadMusic.HasFile)
        {
            String MusicExtension = System.IO.Path.GetExtension(UpLoadMusic.FileName).ToLower();
            String LyricExtension = System.IO.Path.GetExtension(LyricUpload.FileName).ToLower();

            String[] allowedMusicExtensions = { ".mp3", ".wma", ".wav" };

            //for (int i = 0; i < allowedMusicExtensions.Length; i++)
            //{
            //    if (MusicExtension == allowedMusicExtensions[i])
            //    {
            //        FileOK = true;
            //    }
            //}
            if (LyricExtension == ".lrc" && MusicOK)
            {
                FileOK = true;
            }

        }
        if (FileOK)
        {
            try
            {
                //歌曲，歌词上传到服务器
                UpLoadMusic.PostedFile.SaveAs(Musicpath + UpLoadMusic.FileName);
                LyricUpload.PostedFile.SaveAs(Lyricpath + LyricUpload.FileName);
                //int =
                //str = str.Remove(0, i);
                //文件路径等信息写入数据库
                Model.T_Music Music = new Model.T_Music();

                Music.MusicName = UpLoadMusic.FileName.Substring(0, UpLoadMusic.FileName.LastIndexOf("."));
                Music.MusicPath = @"\web\File\Mp3\"+ UpLoadMusic.FileName;
                Music.LyricPath = @"\web\File\Mp3\"+ LyricUpload.FileName;
                Music.StyleId = Convert.ToInt32(DropDownList1.SelectedValue);
                Music.SingerId = Convert.ToInt32(DpDSinger.SelectedValue);
                BLL.T_Music MusicBll = new BLL.T_Music();
                if (MusicBll.Add(Music))
                {
                    //上传成功，给出提示
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), Guid.NewGuid().ToString(), "alert('歌曲上传成功')", true);
                    //Response.Write("<script><alert>上传成功</alert></script>");
                    //Response.Redirect("Login.aspx");

                }
                //else
                //{
                //    //上传失败，给出提示
                //    Page.ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(), "alert('歌曲上传失败，请稍后重试')", true);
                //    //Response.Write("保存失败");
                //}



            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(), "alert('歌曲上传失败，请稍后重试')", true);
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(), "alert('歌曲或歌词类型不正确')", true);
        }



    }
}
