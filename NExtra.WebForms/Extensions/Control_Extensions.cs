using System.IO;
using System.Web.UI;

namespace NExtra.WebForms.Extensions
{
	/// <summary>
	/// Extension methods for System.Web.UI.Control.
	/// </summary>
	/// <remarks>
	/// Author:     Daniel Saidi [daniel.saidi@gmail.com]
	/// Link:       http://danielsaidi.github.com/nextra
	/// </remarks>
	public static class Control_Extensions
	{
		/// <summary>
		/// Retrieve the HTML code for a certain control.
		/// </summary>
		public static string Html(this Control control)
		{
			if (control == null)
				return "";

			var stringWriter = new StringWriter();
			var htmlTextWriter = new HtmlTextWriter(stringWriter);
            
			control.DataBind();
			control.RenderControl(htmlTextWriter);

			return stringWriter.GetStringBuilder().ToString();
		}
	}
}
