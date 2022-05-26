using Microsoft.AspNetCore.Builder;
using Microsoft.Owin;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Session;
using Nancy.TinyIoc;
using Owin;
using System.Web.Services.Description;

[assembly: OwinStartupAttribute(typeof(ShoppingCart.Startup))]
namespace ShoppingCart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           
        }
        //public void ConfigureServices(ServiceCollection services)
        //{
        //    services.AddScoped<shoppingCart, ShoppingCart>();
        //}
    }
}
