using System.Web;
using System.Web.Mvc;

namespace ASPNETMaterialize
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
