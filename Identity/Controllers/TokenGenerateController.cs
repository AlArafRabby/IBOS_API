using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Identity.DbContexts;
using Identity.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenGenerateController : ControllerBase
    {
        private IOptions<Audience> _settings;
        private readonly DB_SecurityContext _context;
        private readonly IdentitiyService _idntity;
        ILogger<TokenGenerateController> _logger;


        public TokenGenerateController(DB_SecurityContext context, IOptions<Audience> settings, IdentitiyService idntity, ILogger<TokenGenerateController> logger)
        {
            _logger = logger;
            this._settings = settings;
            _context = context;
            _idntity = idntity;
        }

        [HttpPost]
        [Route("TokenGenerate")]
        public IActionResult Get([FromBody] User user)
        {
            if (user.UserName.Contains("@")) { string[] username = Regex.Split(user.UserName, "@"); user.UserName = username[0]; }
            ActiveDirectoryValidation activeval = new ActiveDirectoryValidation();

            if (!activeval.ValidateUser(user.UserName, user.Password))
            {
                //var UserRolest = _context.TblUserToken.FirstOrDefault(item => item.StrRefreshToken == user.UserName);
                //if (UserRolest != null)
                //{

                //}
                //else
                //{

                //}


                return NotFound(false);
            }
            //var UserRoles = _context.TblUserToken.FirstOrDefault(item => item.StrRefreshToken == user.UserName);
            ////_context.TblUserRoles.FindAsync(1);
            //if (UserRoles == null)
            //{
            //    return NotFound("User not found");
            //}

            var now = DateTime.UtcNow;
            var claims = new Claim[]
           {

                    new Claim(ClaimTypes.Role,user.UserName.ToString()),
                    new Claim("enroll",user.UserName.ToString()),
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, now.ToUniversalTime().ToString(), ClaimValueTypes.Integer64)
            };

            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_settings.Value.Secret));
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,
                ValidateIssuer = true,
                ValidIssuer = _settings.Value.Iss,
                ValidateAudience = true,
                ValidAudience = _settings.Value.Aud,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                RequireExpirationTime = true,
            };

            var jwt = new JwtSecurityToken(
                issuer: _settings.Value.Iss,
                audience: _settings.Value.Aud,
                claims: claims,
                notBefore: now,
                expires: now.Add(TimeSpan.FromMinutes(60)),
                signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
            );
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);


            var refreshToken = new RefreshToken
            {
                JwtId = encodedJwt,
                UserId = user.UserName.ToString(),// user.Id,
                CreationDate = DateTime.UtcNow,
                ExpiryDate = DateTime.UtcNow.AddMonths(6)
            };


            var responseJson = new
            {
                access_token = encodedJwt,
                expires_in = (int)TimeSpan.FromMinutes(60).TotalSeconds
            };

            return Ok(responseJson);

        }

        [HttpPost]
        [Route("RefreshToken")]
        public async Task<AuthenticationResult> GetRefreshToken([FromBody] RenewToken renewtoken)
        {
            try
            {
                return await _idntity.RefreshTokens(renewtoken);
            }
            catch (Exception ex)
            {
                return new AuthenticationResult
                {
                    Success = false,
                    Token = "",
                    RefreshToken = "".ToString(),
                    expires_in = 0,
                    Errors = new[] { ex.ToString() }
                };
            }
        }
        [HttpPost]
        [Route("UserLogin")]
        public async Task<AuthenticationResult> LoginAsync([FromBody] User user)
        {
            try
            {
                _logger.LogInformation($"Token Generate by User {user.UserName.ToString()}! : {DateTime.UtcNow}");
                return await _idntity.LoginTokenAsync(user);
            }
            catch(Exception ex)
            {
                _logger.LogCritical($"Token Generate Error {user.UserName.ToString()} ", ex);
                _logger.LogError(ex, $"Token Generate Error by {user.UserName.ToString()} ");
                return  new AuthenticationResult
                {
                    Success = false,
                    Token = "",
                    RefreshToken = "".ToString(),
                    expires_in = 0,
                    Errors = new[] { "".ToString() }
                }; 
            }
           
        }

        [HttpPost]
        [Route("MobileUserLogin")]
        public async Task<AuthenticationResult> LoginMobileAsync([FromBody] User user)
        {
            try
            {
                _logger.LogInformation($"Token Generate by Mobile User {user.UserName.ToString()}! : {DateTime.UtcNow}");
                return await _idntity.LoginTokenAsync(user);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Token Generate Mobile Error {user.UserName.ToString()} ", ex);
                _logger.LogError(ex, $"Token Generate Error by Mobile {user.UserName.ToString()} ");
                return new AuthenticationResult
                {
                    Success = false,
                    Token = "",
                    RefreshToken = "".ToString(),
                    expires_in = 0,
                    Errors = new[] { "".ToString() }
                };
            }

        }


    }

   
}