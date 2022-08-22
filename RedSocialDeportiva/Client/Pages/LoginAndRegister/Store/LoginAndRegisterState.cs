namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Store
{
    public class LoginAndRegisterState
    {
        public bool LoginActive { get; set; }
        public bool RegisterActive { get; set; }
        public LoginDto? LoginDto { get; set; }
        public RegisterDto? RegisterDto { get; set; }
    }
}
