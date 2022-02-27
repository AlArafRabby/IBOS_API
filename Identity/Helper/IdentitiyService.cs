using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Identity.DbContexts;
using Identity.Models.DB_Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Identity.Helper
{
    public class IdentitiyService
    {
        private IOptions<Audience> _settings;
        private readonly DB_SecurityContext _context;

        public IdentitiyService(DB_SecurityContext context, IOptions<Audience> settings)
        {
            this._settings = settings;
            _context = context;
        }

        public async Task<AuthenticationResult> LoginTokenAsync(User user)
        {
            try
            {
                if (user.UserName.Contains("@")) { string[] username = Regex.Split(user.UserName, "@"); user.UserName = username[0]; }

                ActiveDirectoryValidation activeval = new ActiveDirectoryValidation();
               //if (IsPhoneNumber(user.UserName))
               // {
               //    return await MobileUserAuth(user);
               //     //var UserInfo = _context.TblUserToken.FirstOrDefault(item => item.StrEmail == user.UserName
               //     //&& item.StrPassword == user.Password && item.YsnEnable == true);
               //     //if (UserInfo != null)
               //     //{
               //     //    return await GenerateAuthenticationResultForUserAsync(UserInfo, "Login Token");
               //     //}
               //     //else
               //     //{
               //     //    return new AuthenticationResult
               //     //    {
               //     //        Success = false,
               //     //        Token = "",
               //     //        RefreshToken = "".ToString(),
               //     //        expires_in = 0,
               //     //        Errors = new[] { "User Authentication Faild" }
               //     //    };
               //     //}

               // }
                if (activeval.ValidateUser(user.UserName, user.Password))
                {
                    return await AkijDomain(user);
                    //var UserInfo = _context.TblUserToken.FirstOrDefault(item => item.StrEmail == user.UserName);

                    //if (UserInfo == null)
                    //{
                    //    var userinfo = new TblUserToken
                    //    {
                    //        StrEmail = user.UserName,
                    //        StrUid = Guid.NewGuid(),
                    //        YsnEnable = true,
                    //        StrDomain = "akij.net"
                    //    };
                    //    await _context.TblUserToken.AddAsync(userinfo);
                    //    await _context.SaveChangesAsync();
                    //    UserInfo = userinfo;
                    //}

                    //return await GenerateAuthenticationResultForUserAsync(UserInfo, "Login Token");
                }
                else
                {
                    return new AuthenticationResult
                    {
                        Success = false,
                        Token = "",
                        RefreshToken = "".ToString(),
                        expires_in = 0,
                        Errors = new[] { "User Authentication Faild" }
                    };
                }
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
        public async Task<AuthenticationResult> LoginMobileTokenAsync(User user)
        {
            try
            {
                if (user.UserName.Contains("@")) { string[] username = Regex.Split(user.UserName, "@"); user.UserName = username[0]; }

               
                if (IsPhoneNumber(user.UserName))
                {
                    return await MobileUserAuth(user);
                }

                else
                {
                    return new AuthenticationResult
                    {
                        Success = false,
                        Token = "",
                        RefreshToken = "".ToString(),
                        expires_in = 0,
                        Errors = new[] { "User Authentication Faild" }
                    };
                }
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

        public async Task<AuthenticationResult> RefreshTokens(RenewToken token)
        {
            try
            {
                var UserRoles = _context.TblUserToken.FirstOrDefault(itm => itm.StrRefreshToken == token.RefreshToken && itm.StrToken == token.Token);
                // && itm.StrUid.ToString() == token.UID.ToString());
                if (UserRoles == null)
                {
                    return new AuthenticationResult
                    {
                        Success = false,
                        Errors = new[] { "Invalid token" }
                    };

                }
                else
                {
                    return await GenerateAuthenticationResultForUserAsync(UserRoles, "Refresh Token");
                }
            }
            catch
            {
                return new AuthenticationResult
                {
                    Success = false,
                    Errors = new[] { "Invalid token" }
                };
            }

            


        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
        public async Task<AuthenticationResult> GenerateAuthenticationResultForUserAsync(TblUserToken user, string tokenStatus)
        {
            var now = DateTime.UtcNow;
            try
            {

                var claims = new Claim[]
               {

                    new Claim(ClaimTypes.Role,user.StrUid.ToString()),
                    new Claim("enroll",user.StrUid.ToString()),
                    new Claim(JwtRegisteredClaimNames.Sub, user.StrEmail),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, now.ToUniversalTime().ToString(), ClaimValueTypes.Integer64)
                };

                var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_settings.Value.Secret));


                var jwt = new JwtSecurityToken(
                    issuer: _settings.Value.Iss,
                    audience: _settings.Value.Aud,
                    claims: claims,
                    notBefore: now,
                    expires: now.Add(TimeSpan.FromMinutes(60)),
                    signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
                );
                var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);


                user.StrToken = encodedJwt;
                user.StrRefreshToken = Guid.NewGuid().ToString();// GenerateRefreshToken() + ;


                DateTime actionTime = DateTime.Now;
                var detalis = new TblUserTokenDetalis
                {
                    StrUid = Guid.NewGuid().ToString(),
                    StrToken = encodedJwt,
                    StrRefreshToken = user.StrRefreshToken,
                    IntRefTokenId = user.IntId,
                    StrStatus = tokenStatus


                };

                _context.TblUserToken.Update(user);
                await _context.TblUserTokenDetalis.AddAsync(detalis);
                _context.SaveChanges();

                return new AuthenticationResult
                {
                    Success = true,
                    Token = encodedJwt,
                    RefreshToken = user.StrRefreshToken,
                    expires_in = (int)TimeSpan.FromMinutes(60).TotalSeconds,
                    ActionTime = TimeZones.GetCurrentDatTime()//actionTime.ToString("yyyy-MM-dd hh:mm:ss.ff")
                };
            }
            catch (Exception ex)
            {
                return new AuthenticationResult
                {
                    Success = false,
                    Token = "",
                    RefreshToken = "",
                    expires_in = 0,
                    ActionTime = "",
                    Errors = new[] { ex.Message }// ""//"".ToString("dd-mm-yyyy hh:mm:ss.ff")
                };
            }



        }

        public static bool IsPhoneNumber(string number)
        {
            try
            {
                bool b1 = Microsoft.VisualBasic.Information.IsNumeric(number);

                return b1;
            }
            catch { return false; }
           

        }

        public async Task<AuthenticationResult> MobileUserAuth(User user)
        {

            var UserInfo = _context.TblUserToken.FirstOrDefault(item => item.StrEmail == user.UserName
                   && item.StrPassword == user.Password && item.YsnEnable == true);
            if (UserInfo != null)
            {
                return await GenerateAuthenticationResultForUserAsync(UserInfo, "Login Token");
            }
            else
            {
                return new AuthenticationResult
                {
                    Success = false,
                    Token = "",
                    RefreshToken = "".ToString(),
                    expires_in = 0,
                    Errors = new[] { "User Authentication Faild" }
                };
            }



        }

        public async Task<AuthenticationResult> AkijDomain(User user)
        {
            
               
            try
            {
                var UserInfo = _context.TblUserToken.FirstOrDefault(item => item.StrEmail == user.UserName);

                if (UserInfo == null)
                {
                    var userinfo = new TblUserToken
                    {
                        StrEmail = user.UserName,
                        StrUid = Guid.NewGuid(),
                        YsnEnable = true,
                        StrDomain = "akij.net"
                    };
                    await _context.TblUserToken.AddAsync(userinfo);
                    await _context.SaveChangesAsync();
                    UserInfo = userinfo;
                }

                return await GenerateAuthenticationResultForUserAsync(UserInfo, "Login Token");

            }
            catch (Exception ex)
            {
                return new AuthenticationResult
                {
                    Success = false,
                    Token = "",
                    RefreshToken = "",
                    expires_in = 0,
                    ActionTime = "",
                    Errors = new[] { ex.Message }// ""//"".ToString("dd-mm-yyyy hh:mm:ss.ff")
                };

            }


        }
        

    }
}
