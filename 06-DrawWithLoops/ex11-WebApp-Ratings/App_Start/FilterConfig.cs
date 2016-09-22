using System.Web;
using System.Web.Mvc;

namespace ex11_WebApp_Ratings
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
