using System.Web;
using System.Web.Mvc;

namespace ADO_Entity_DIff_of_Inhert_and_Compo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
