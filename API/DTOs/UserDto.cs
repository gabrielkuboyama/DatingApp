using System;
using System.Data.SqlTypes;

namespace API.DTOs;

public class UserDto
{
    public required string UserName { get; set; }
    public required string Token { get; set; }
}
