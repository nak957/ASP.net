using System.Web;
using System.Web.Mvc;

namespace PTQlesson08K22CNT2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
