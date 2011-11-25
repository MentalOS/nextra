using System.Web;
using System.Web.Mvc;

namespace NExtra.Mvc.HtmlHelpers
{
    /// <summary>
    /// This helper can be used to handle global resources for views.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://www.saidi.se/nextra
    /// </remarks>
    public static class GlobalResourceHelper
    {
        /// <summary>
        /// Format a global resource file value for display.
        /// Use this.GlobalResource(...) in the view to add
        /// a translated text to the view.
        /// </summary>
        public static IHtmlString GlobalResource(this HtmlHelper helper, string resource)
        {
            return ResourceFileValueHelper.ResourceFileValueToHtml(helper, resource);
        }
    }
}
