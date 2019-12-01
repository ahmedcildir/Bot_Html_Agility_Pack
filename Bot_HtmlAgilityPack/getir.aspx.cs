using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bot_HtmlAgilityPack
{
    public partial class getir : System.Web.UI.Page
    {
        vericek veri = new vericek();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<br/> Şehir " + veri.uniget("https://sinavla.com/universiteler", "//*[@id='example']/tbody/tr[1]/td[3]"));

            //Response.Write("<br/> Ad" + veri.uniget("https://togrencit.com/ar/universities/", "/html/body/div[3]/div[4]/div/div/div/div[6]/div[2]/div[1]/a/img"));
            //for (int i = 2; i < 15; i++)
            //{
            //    Response.Write("<br/> fot   " + veri.uniget("https://toptalent.co/turkiyedeki-universiteler-listesi", "/html/body/div[10]/div/div/div[1]/div/div/table[2]/tbody/tr[" + i + "]/td[2]/img"));
            //    Response.Write("<br/> Ad    " + veri.uniget("https://toptalent.co/turkiyedeki-universiteler-listesi", "/html/body/div[10]/div/div/div[1]/div/div/table[2]/tbody/tr["+i+"]/td[3]/strong"));
            //    Response.Write("<br/> Şehir " + veri.uniget("https://toptalent.co/turkiyedeki-universiteler-listesi", "/html/body/div[10]/div/div/div[1]/div/div/table[2]/tbody/tr[" + i + "]/td[4]/strong"));
            //    Response.Write("<br/> Web   " + veri.uniget("https://toptalent.co/turkiyedeki-universiteler-listesi", "/html/body/div[10]/div/div/div[1]/div/div/table[2]/tbody/tr[" + i + "]/td[5]/a"));
            //    Response.Write("<br/> Tür   " + veri.uniget("https://toptalent.co/turkiyedeki-universiteler-listesi", "/html/body/div[10]/div/div/div[1]/div/div/table[2]/tbody/tr[" + i + "]/td[6]"));
            //Response.Write("<br/>" + veri.uniget("http://metropolkurslari.com/2019-yili-yurtdisindan-ogrenci-kabulu-ve-universitelere-basvurular-rehberi/", "/html/body/div[2]/div[4]/div[1]/div[1]/div/div/div/div[2]/div[1]/div/div[6]/div[2]/p[" + i + "]/strong"));
            //Response.Write("<br/>" + veri.uniget("http://metropolkurslari.com/2019-yili-yurtdisindan-ogrenci-kabulu-ve-universitelere-basvurular-rehberi/", "/html/body/div[2]/div[4]/div[1]/div[1]/div/div/div/div[2]/div[1]/div/div[6]/div[2]/p[" + i + "]/text()[2]"));
            //Response.Write("<br/>" + veri.uniget("http://metropolkurslari.com/2019-yili-yurtdisindan-ogrenci-kabulu-ve-universitelere-basvurular-rehberi/", "/html/body/div[2]/div[4]/div[1]/div[1]/div/div/div/div[2]/div[1]/div/div[6]/div[2]/p[" + i + "]/a"));
            //Response.Write("<br/>" + veri.uniget("http://metropolkurslari.com/2019-yili-yurtdisindan-ogrenci-kabulu-ve-universitelere-basvurular-rehberi/", "/html/body/div[2]/div[4]/div[1]/div[1]/div/div/div/div[2]/div[1]/div/div[6]/div[2]/p[" + i + "]/text()[4]"));
            //Response.Write("<br/>" + veri.uniget("http://metropolkurslari.com/2019-yili-yurtdisindan-ogrenci-kabulu-ve-universitelere-basvurular-rehberi/", "/html/body/div[2]/div[4]/div[1]/div[1]/div/div/div/div[2]/div[1]/div/div[6]/div[2]/p["+i+"]/text()[5]"));
            Response.Write("<br/>");
                //Response.Write("<br/>" + veri.uniget("http://metropolkurslari.com/2019-yili-yurtdisindan-ogrenci-kabulu-ve-universitelere-basvurular-rehberi/", "").ToString());
            //}
        }
    }
}