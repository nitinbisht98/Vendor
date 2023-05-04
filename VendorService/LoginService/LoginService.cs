using Microsoft.Extensions.Configuration;
using Vendor.Interface.Model.Response;
using Vendor.Repository.Login;
using Vendor.Services.Model.Request;
using Vendor.Services.Model.Response;

namespace Vendor.Services.Login
{
    public class LoginService : ILoginService
    {
        public readonly ILoginRepository login;
        public readonly IConfiguration configuration;

        public LoginService(ILoginRepository login, IConfiguration configuration)
        {
            this.login = login;
            this.configuration = configuration;
        }

        public Response AuthenticateUser(LoginRequest credential)
        {
            Response res = new Response();
            BaseResponse response = login.AuthenticateUser(credential);
            if (response != null)
            {
                if (response.IsSuccess == 1)
                {
                    res.IsSuccess = 1;
                    res.Message = "Login Successfully";
                }
                else
                {
                    res.IsSuccess = 0;
                    res.Message = "Invalid Credentials.";
                }
            }
            else
            {
                res.IsSuccess = 0;
                res.Message = "Unable to Login.";
            }
            return res;
        }
    }
}
