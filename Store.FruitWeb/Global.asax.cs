using DataAccessLayer.Mappers;
using Store.FruitWeb.App_Start;
using Store.FruitWeb.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Store.FruitWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            FruitConfiguration();            
        }

        public void FruitConfiguration()
        {
            AutoMapperDomainConfiguration.Configure();
            AutoMapperWebConfiguration.Configure();
        }
    }
}
