using System.Web;
using System.Web.Mvc;

namespace Internet_Photo_Album
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
