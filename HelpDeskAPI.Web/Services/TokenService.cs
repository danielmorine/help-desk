using HelpDeskAPI.Repository.Schemas;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

namespace HelpDeskAPI.Web.Services
{
    public interface ITokenService
    {
        string GenerateToken(ApplicationUser user);    
    }

    public class TokenService : ITokenService
    {
        private readonly string _secrets;
        private readonly double _seconds;
        public TokenService(IConfiguration configuration)
        {
            _secrets = configuration.GetConnectionString("Secrets:Key");
            _seconds = double.Parse(configuration.GetConnectionString("Secrets:ExpiresInSeconds"));

        }
        public string GenerateToken(ApplicationUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secrets);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                }),
                Expires = DateTime.UtcNow.AddMinutes(_seconds),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
