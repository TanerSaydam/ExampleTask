﻿using MediatR;

namespace ExampleTask.Application.Features.Auth.Login;
public sealed record LoginCommand(
    string UserName,
    string Password) : IRequest<string>;
    
