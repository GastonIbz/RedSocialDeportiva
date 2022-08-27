namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Store
{
    public class LoginAndRegisterState
    {
        public bool LoginActive { get; set; }
        public bool RegisterActive { get; set; }
        public string ClassCssForm { get; set; }
        public DataLoginDTO? LoginDto { get; set; }
        public DataRegisterDTO? RegisterDto { get; set; }
    }
}
