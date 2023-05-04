using Vendor.Repository.Login;
using Vendor.Services.Login;

namespace Vendor.API.Injectable
{
    public class InjectableServices
    {
        public static void Services(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ILoginService, LoginService>();
            builder.Services.AddTransient<ILoginRepository, LoginRepository>();
        }

    }
}
