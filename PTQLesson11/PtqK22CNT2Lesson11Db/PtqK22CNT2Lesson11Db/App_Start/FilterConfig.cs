using System.Web;
using System.Web.Mvc;

namespace PtqK22CNT2Lesson11Db
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
