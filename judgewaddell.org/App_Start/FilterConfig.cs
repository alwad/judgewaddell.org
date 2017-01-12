using System.Web;
using System.Web.Mvc;

namespace judgewaddell.org
{
    public class FilterConfig
    {
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new ErrorHandler.AiHandleErrorAttribute());
		}
	}
}
