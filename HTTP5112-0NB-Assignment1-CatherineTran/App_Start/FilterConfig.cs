using System.Web;
using System.Web.Mvc;

namespace HTTP5112_0NB_Assignment1_CatherineTran
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
