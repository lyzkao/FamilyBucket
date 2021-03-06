﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Pinzhi.Identity.Interface;
using Pinzhi.Identity.DTO.Auth;
using Bucket.WebApi;
namespace Pinzhi.Identity.WebApi.Controllers
{
    /// <summary>
    /// 认证授权控制器
    /// </summary>
    [Produces("application/json")]
    public class AuthController : ApiControllerBase
    {
        /// <summary>
        /// 业务实现
        /// </summary>
        private readonly IAuthBusiness _authBusiness;
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="authBusiness"></param>
        public AuthController(IAuthBusiness authBusiness)
        {
            _authBusiness = authBusiness;
        }
        /// <summary>
        /// 账户登陆 - 密码登陆
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/auth/login")]
        public async Task<LoginOutput> Login([FromBody] LoginInput input)
        {
            return await _authBusiness.LoginAsync(input);
        }
    }
}