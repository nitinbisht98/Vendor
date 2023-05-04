using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendor.Services.Model.Request;
using Vendor.Services.Model.Response;

namespace Vendor.Repository.Login
{
    public interface ILoginRepository
    {
        public BaseResponse AuthenticateUser(LoginRequest credential);
    }
}
