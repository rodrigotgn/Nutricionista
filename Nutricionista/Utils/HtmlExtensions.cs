using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nutricionista.Utils
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString Image(this HtmlHelper html, byte[] image, string htmlClass = "")
        {
            var img = String.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(image));
            return new MvcHtmlString("<img src='" + img + "' class='" + htmlClass + "' />");
        }
    }
}