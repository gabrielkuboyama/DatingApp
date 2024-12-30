using System;
using API.Model;

namespace API.Interfaces;

public interface ITokenService
{
    string CrateToken(AppUser user);
}
