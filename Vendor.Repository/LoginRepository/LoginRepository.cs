using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendor.Services.Model.Request;
using Vendor.Services.Model.Response;

namespace Vendor.Repository.Login
{
    public class LoginRepository : ILoginRepository
    {
        private readonly DbContext dbContext;
        public LoginRepository(IConfiguration configuration)
        {
            this.dbContext = new DbContext(configuration);
        }
        public BaseResponse AuthenticateUser(LoginRequest credential)
        {
            using (IDbConnection db = dbContext.GetConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("_username", credential.UserName);
                parameters.Add("_password", credential.Password);
                return db.Query<BaseResponse>("Login", parameters, commandType: CommandType.StoredProcedure).Single();
            }
        }

    }
}
