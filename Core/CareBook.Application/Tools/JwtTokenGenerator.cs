using CareBook.Application.Dtos;
using CareBook.Application.Features.Mediator.Results.AppUserResults;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Tools
{
    public class JwtTokenGenerator
    {
        public static TokenResponseDto GenerateToken(GetCheckAppUserQueryResult result)
        {
            var claims = new List<Claim>();
            if (!string.IsNullOrWhiteSpace(result.Role))
                claims.Add(new Claim(ClaimTypes.Role, result.Role));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, result.ID.ToString()));
            if (!string.IsNullOrWhiteSpace(result.UserName))
                claims.Add(new Claim("UserName", result.UserName));
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokeDefaults.Key));
            var signinCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expireDate = DateTime.UtcNow.AddDays(JwtTokeDefaults.Expire);
            JwtSecurityToken token = new JwtSecurityToken(issuer: JwtTokeDefaults.ValidIssuer, audience: JwtTokeDefaults.ValidAudience,
                claims: claims, notBefore: DateTime.UtcNow, expires: expireDate, signingCredentials: signinCredentials);

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            return new TokenResponseDto(tokenHandler.WriteToken(token), expireDate);

        }
    }
}
