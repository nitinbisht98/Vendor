using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendor.Interface.Model.Response;
using Vendor.Services.Model.Request;

namespace Vendor.Services.Login
{
    public interface ILoginService
    {
        public Response AuthenticateUser(LoginRequest credential);
    }
}
