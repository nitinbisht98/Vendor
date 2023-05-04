using Vendor.Services.Model.Response;

namespace Vendor.Interface.Model.Response
{
    public class Response : BaseResponse
    {
        public dynamic Result { get; set; }
    }
    public class LoginResponse : BaseResponse
    {
        public int Id { get; set; }
    }

}
