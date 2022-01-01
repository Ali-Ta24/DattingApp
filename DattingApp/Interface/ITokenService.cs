using DattingApp.Entities;

namespace DattingApp.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}