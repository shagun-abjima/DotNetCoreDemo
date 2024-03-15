using BookStoreApi.Model;
using Microsoft.AspNetCore.Identity;

namespace BookStoreApi.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel  signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
    
}
