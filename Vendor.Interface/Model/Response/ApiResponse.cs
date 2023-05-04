using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor.Interface.Model.Response
{
    public class ApiResponse
    {
        private readonly string message;
        private object result;
        public ApiResponse(string message,object result) 
        {
            this.message = message; 
            this.result = result;   
        }
    }
}
