﻿namespace Leasy.API.Security.Domain.Services.Communication;

public class UpdateRequest
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}