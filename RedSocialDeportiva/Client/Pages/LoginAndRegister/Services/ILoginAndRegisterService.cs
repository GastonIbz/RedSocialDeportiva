namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Services
{
    public interface ILoginAndRegisterService
    {
        Task<(UserModels, string)> login();
    }
}