using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using SANNA_BL.Models.DTO;
using SANNA_BL.Models.Entity;
using Microsoft.AspNetCore.Identity;

namespace SANNA_BL.Interface
{
    public interface IAuthManager
    {

        Task<List<Claim>> GetValidClaims(AppUser user);
        Task<AuthResult> VerifyToken(TokenRequest tokenRequest);
        Task<AuthResult> GenerateJwtToken(AppUser user);
    }
}
