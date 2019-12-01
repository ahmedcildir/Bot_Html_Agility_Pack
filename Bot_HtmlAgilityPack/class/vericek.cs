using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//HtmlAgilityPack #procect/Manage NuGet packet/HtmlAgilityPack projeye dahil et
using HtmlAgilityPack;
using System.Net;//kütüphanesini ekle
using System.Text;//kütüphanesini ekle

namespace Bot_HtmlAgilityPack
{

    public class vericek
    {
        public string html;
        public Uri url;
        public string uniget(string Url, string xp)
        {
            try
            {
                //url oluştue
                url = new Uri(Url);
            }
            catch (UriFormatException ex)
            {
            }
            catch (ArgumentNullException ex)
            {
            }
            //alıcı nesne 
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                html = client.DownloadString(url);
            }
            catch (WebException ex)
            {
            }
           
            try
            {
                //xml kullanmamak için HtmlDocument kullanılır
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                //gelen değeri sonuc değişkenine atama
                string sonuc = doc.DocumentNode.SelectSingleNode(xp).InnerText;
                //sonuç değişkenini geriye döndür
                return sonuc;
            }
            catch (NullReferenceException ex)
            {

                return null;
            }            
        }
    }

}