using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Entity;

public class AccessToken
{
    public string AccessTokenString { get; }

    public AccessToken(in string secretKey, in string nickName)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var claims = new List<Claim>
        {
            new("nickname", nickName)
        };

        var token = new JwtSecurityToken(
            issuer: "Jerey",
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(30),
            signingCredentials: creds
        );

        AccessTokenString = new JwtSecurityTokenHandler().WriteToken(token);
    }
}
