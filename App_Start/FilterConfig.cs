using System.Web;
using System.Web.Mvc;

namespace u21635618HW6INF272
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
