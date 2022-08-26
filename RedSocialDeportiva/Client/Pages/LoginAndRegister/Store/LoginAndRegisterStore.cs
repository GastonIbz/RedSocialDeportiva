namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Store
{
    public class LoginAndRegisterStore
    {

        #region State inicial
        private LoginAndRegisterState _state;
        #endregion


        #region CONSTRUCTOR
        public LoginAndRegisterStore()
        {
            this._state = new LoginAndRegisterState
            {
                LoginActive = true,
                RegisterActive = false,
                LoginDto = new LoginDto(),
                RegisterDto = new RegisterDto()
            };
        }
        #endregion

        #region Metodos para obtener y setear los States


        public bool IsLoginActive() => this._state.LoginActive;
        public void SetLoginActive(bool newState)
        {
            this._state.LoginActive = newState;
            ExecuteStateChange();
        }


        public bool IsRegisterActive() => this._state.RegisterActive;
        public void SetRegisterActive(bool newState)
        {
            this._state.RegisterActive = newState;
            ExecuteStateChange();
        }


        public LoginDto GetFormLogin() => this._state.LoginDto;
        public void ResetFormLogin() 
        {
            this._state.LoginDto = new LoginDto();
            ExecuteStateChange();
        }

        public RegisterDto GetFormRegister() => this._state.RegisterDto;
        public void ResetFormRegister()
        {
            this._state.RegisterDto = new RegisterDto();
            ExecuteStateChange();
        } 

        #endregion Metodos para obtener y setear los States



        #region Listeners Patron Observer || Gestion de eventos


        // Actua como controlador de eventos.
        private Action _listeners;

        // Permite subscribirnos a una accion. 
        public void SubscribeChangedState(Action listener) => this._listeners += listener;

        // Permite desubscribirnos a una accion.
        public void DesubscribeChangedState(Action listener) => this._listeners -= listener;

        // Invocamos la accion 
        private void ExecuteStateChange() => this._listeners.Invoke();


        #endregion

        /// Nota: Debemos inyectar la dependencia dentro de los Services de Program.cs
    }
}
