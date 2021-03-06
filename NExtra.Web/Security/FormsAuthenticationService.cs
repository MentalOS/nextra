using System.Web;
using System.Web.Security;
using NExtra.Security;

namespace NExtra.Web.Security
{
    /// <summary>
    /// This class can be used as a facade for the static
    /// FormsAuthentication class.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://danielsaidi.github.com/nextra
    /// </remarks>
    public class FormsAuthenticationService : IAuthenticationService
    {
        public bool Authenticate(string userName, string password)
        {
            return FormsAuthentication.Authenticate(userName, password);
        }

        public bool IsAuthenticated()
        {
            return HttpContext.Current.Request.IsAuthenticated;
        }

        public void SignIn(string userName, bool createPersistentCookie)
        {
            FormsAuthentication.SetAuthCookie(userName, createPersistentCookie);
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}
