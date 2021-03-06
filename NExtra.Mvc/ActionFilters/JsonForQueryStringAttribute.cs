using System.Web;
using System.Web.Mvc;

namespace NExtra.Mvc.ActionFilters
{
    /// <summary>
    /// This attribute can be added to controller actions
    /// and will send the view model as JSON, if either a
    /// query var simply exists or if has a certain value.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://danielsaidi.github.com/nextra
    /// </remarks>
    public class JsonForQueryStringAttribute : ActionFilterAttribute
    {
        private readonly string _queryVariableName;
        private readonly string _queryVariableValue;


        public JsonForQueryStringAttribute(string queryVariableName)
            : this(queryVariableName, null)
        {
        }

        public JsonForQueryStringAttribute(string queryVariableName, string queryVariableValue)
        {
            _queryVariableName = queryVariableName;
            _queryVariableValue = queryVariableValue;
        }


        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            OnActionExecuted(filterContext, filterContext.HttpContext.Request);
        }

        public void OnActionExecuted(ActionExecutedContext filterContext, HttpRequestBase httpRequest)
        {
            var queryString = httpRequest.QueryString[_queryVariableName];

            if (queryString != null)
            {
                if (_queryVariableValue == null || _queryVariableValue == queryString)
                {
                    var result = new JsonResult
                    {
                        JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                        Data = filterContext.Controller.ViewData.Model
                    };

                    filterContext.Result = result;
                }
            }

            base.OnActionExecuted(filterContext);
        }
    }
}
