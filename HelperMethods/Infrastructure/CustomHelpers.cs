using System.Collections.Generic;
using System.Web.Mvc;

namespace HelperMethods.Infrastructure
{
    public static class CustomHelpers
    {
        public static MvcHtmlString ListArrayItems(this HtmlHelper html, IEnumerable<string> list)
        {
            var tag = new TagBuilder("ul");
            foreach (var item in list)
            {
                var itemTag = new TagBuilder("li");
                itemTag.SetInnerText(item);
                tag.InnerHtml += itemTag.ToString();
            }
            return new MvcHtmlString(tag.ToString());
        }

        public static MvcHtmlString DisplayMessage(this HtmlHelper html, string msg)
        {
            var encoded = html.Encode(msg);
            var result = string.Format("This is the message: <p>{0}</p>", encoded);
            return new MvcHtmlString(result);
        }
    }
}