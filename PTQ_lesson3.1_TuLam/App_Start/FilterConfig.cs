using System.Web;
using System.Web.Mvc;

namespace PTQ_lesson3._1_TuLam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
