using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StWebLibrary.Library
{
    public static class MyClass
    {
        /*Burada Html Helperları kendimiz yazdırıyoruz daha sonra bu class ıın namespace sini using ile view kısmına ekleyip Html.Button ya da Html.Pati gibi kullanabiliriz*/

        #region Enums

        public enum ButtonType
        {
            button=0,
            submit=1,
            reset=2,
        }
        #endregion
        #region Helpers
        public static MvcHtmlString Button(this HtmlHelper helper,string id="",ButtonType typ=ButtonType.button,string text = "")
        {
            string html=string.Format("<button id='{0}' name='{0}' type='{1}'>{2}</button>",
                id,typ.ToString(),text);
            return MvcHtmlString.Create(html);
        }
        public static MvcHtmlString Button(this HtmlHelper helper,string id="",string cssClass="",ButtonType typ=ButtonType.button,string text = "")
        {
            TagBuilder tag = new TagBuilder("button");
            tag.AddCssClass(cssClass);
            tag.GenerateId(id);
            tag.SetInnerText(text);
            tag.Attributes.Add(new KeyValuePair<string, string>("type", typ.ToString()));
            tag.Attributes.Add(new KeyValuePair<string, string>("name", id));
            return MvcHtmlString.Create(tag.ToString());
            
        }
        #endregion
    }
}