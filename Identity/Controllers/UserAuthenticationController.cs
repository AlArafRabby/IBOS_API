using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Identity.DbContexts;
using Identity.Helper;
using Identity.Models.DB_Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Novell.Directory.Ldap;

namespace Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthenticationController : ControllerBase
    {
        ILogger<UserAuthenticationController> _logger;
        private readonly DB_SecurityContext _context;

        private readonly IConfiguration _configuration;
        private readonly AppSettings _appSettings;

        public UserAuthenticationController(DB_SecurityContext context, IOptions<AppSettings> appSettings, IConfiguration configuration, ILogger<UserAuthenticationController> logger)
        {
            _logger = logger;
            _context = context;
            _appSettings = appSettings.Value;
            _configuration = configuration;
        }


        //GET: api/UserRoles/5 
        [HttpGet]
        [Route("GetToken")]
        public async Task<ActionResult<TblUserToken>> userInfo(string username, string password)
        {
            ActiveDirectoryValidation activeval = new ActiveDirectoryValidation();
            if (!activeval.ValidateUser(username, password))
            {
                return NotFound();
            }
            var UserRoles = _context.TblUserToken.FirstOrDefault(item => item.StrRefreshToken == username);
            //_context.TblUserRoles.FindAsync(1);
            if (UserRoles == null)
            {
                return NotFound();
            }
            var entity = _context.TblUserToken.FirstOrDefault(item => item.StrRefreshToken == username);

            //if (Convert.ToString(UserRoles.StrToken).Length > 10)
            //{
            //    UserRoles.StrToken = UserRoles.StrToken;
            //}
            //else
            //{

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);


            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                       new Claim(ClaimTypes.Name,UserRoles.StrUid.ToString()),
                       new Claim(ClaimTypes.Role,UserRoles.StrRefreshToken.ToString()),
                       new Claim("enroll",UserRoles.StrUid.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(8),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            UserRoles.StrToken = tokenHandler.WriteToken(token);

            UserRoles.StrToken = UserRoles.StrToken;

            _context.TblUserToken.Update(UserRoles);
            _context.SaveChanges();
            // }


            // remove password before returning

            return UserRoles;
        }


    }

}