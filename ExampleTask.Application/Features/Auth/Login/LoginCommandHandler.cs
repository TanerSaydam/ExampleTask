using ExampleTask.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ExampleTask.Application.Features.Auth.Login;
internal sealed class LoginCommandHandler(
    UserManager<AppUser> userManager) : IRequestHandler<LoginCommand, string>
{
    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        AppUser? appUser = await userManager.FindByNameAsync(request.UserName);

        if(appUser is null)
        {
            throw new ArgumentException("Kullanıcı adı bulunamadı!");
        }

        bool isPasswordTrue = await userManager.CheckPasswordAsync(appUser, request.Password);

        if (!isPasswordTrue)
        {
            throw new ArgumentException("Şifre hatalı!");
        }

        return "Kullanıcı girişi yapıldı!";
    }
}
