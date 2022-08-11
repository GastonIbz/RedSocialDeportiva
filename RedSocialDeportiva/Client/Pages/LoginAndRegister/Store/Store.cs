namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Store
{
    public class LoginAndRegisterStore
    {

        #region State con valores iniciales

        private LoginAndRegisterState _state;

        public LoginAndRegisterStore()
        {
            _state = new LoginAndRegisterState
            {
                LoginActive = true,
                RegisterActive = false,
                IsLoader = false,
                MessageModal = "",
                LoginDto = new LoginDto(),
                RegisterDto = new RegisterDto()
            };
        }

        #endregion State con valores iniciales


        #region Metodos para obtener y setear los States


        public bool IsLoginActive() => _state.LoginActive;
        public void SetLoginActive(bool newState)
        {
            _state.LoginActive = newState;
            ExecuteStateChange();
        }


        public bool IsRegisterActive() => _state.RegisterActive;
        public void SetRegisterActive(bool newState)
        {
            _state.RegisterActive = newState;
            ExecuteStateChange();
        }


        public bool IsLoader() => _state.IsLoader;
        public void SetIsLoader(bool newState)
        {
            _state.IsLoader = newState;
            ExecuteStateChange();
        }


        public string MessageModal() => _state.MessageModal;
        public void SetMessageModal(string newState)
        {
            _state.MessageModal = newState;
            ExecuteStateChange();
        }


        public LoginDto GetFormLogin() => _state.LoginDto;
        public void ResetFormLogin() 
        {
            _state.LoginDto = new LoginDto();
            ExecuteStateChange();
        }

        public RegisterDto GetFormRegister() => _state.RegisterDto;
        public void ResetFormRegister()
        {
            _state.RegisterDto = new RegisterDto();
            ExecuteStateChange();
        } 

        #endregion Metodos para obtener y setear los States



        #region Listeners Patron Observer || Gestion de eventos


        // Actua como controlador de eventos.
        private Action _listeners;

        // Permite subscribirnos a una accion.
        public void AddStateChangeListeners(Action listener) => _listeners += listener;

        // Permite desubscribirnos a una accion.
        public void RemoveStateChangeListeners(Action listener) => _listeners -= listener;

        // Invocamos la accion 
        private void ExecuteStateChange() => _listeners.Invoke();


        #endregion

        /// Nota: Debemos inyectar la dependencia dentro de los Services de Program.cs
    }
}
