using System;

namespace NExtra.Extensions
{
    /// <summary>
    /// Extension methods for System.Uri.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://www.saidi.se/nextra
    /// </remarks>
    public static class UriExtensions
    {
        /// <summary>
        /// Get the root url for a web-based Uri, e.g. http://www.foobar.com:8080
        /// for http://www.foobar.com:8080/foo/bar.
        /// </summary>
        /// <param name="uri">The Uri of interest.</param>
        /// <returns>The root url for the Uri.</returns>
        public static Uri GetRootUri(this Uri uri)
        {
            var port = (uri.IsDefaultPort) ? "" : ":" + uri.Port;
            return new Uri(string.Format("{0}://{1}{2}", uri.Scheme, uri.Host, port));
        }
    }
}