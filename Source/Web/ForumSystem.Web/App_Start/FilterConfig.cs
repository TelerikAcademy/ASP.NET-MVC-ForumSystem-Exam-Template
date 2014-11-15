namespace ForumSystem.Web
{
    using System.Web.Mvc;

    using ForumSystem.Web.Infrastructure.Filters;

    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ApplicationVersionHeaderFilter());
        }
    }
}
