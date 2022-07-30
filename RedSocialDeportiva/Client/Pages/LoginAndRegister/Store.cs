namespace RedSocialDeportiva.Client.Pages.LoginAndRegister
{

    #region Clase del State
    
    public class LoginAndRegisterState
    {
        public bool LoginActive { get; set; }
        public bool RegisterActive { get; set; }
        public bool IsLoader { get; set; }
        public string? MessageModal { get; set; }
        public LoginDto LoginDto { get; set; } 
    }
    
    #endregion

    // Definimos el store junto al State y los metodos del store
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
                LoginDto = new LoginDto()

            };
        }

        #endregion State con valores iniciales


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


        public bool IsLoader() => this._state.IsLoader;
        public void SetIsLoader(bool newState)
        {
            this._state.IsLoader = newState;
            ExecuteStateChange();
        }


        public string MessageModal() => this._state.MessageModal;
        public void SetMessageModal(string newState)
        {
            this._state.MessageModal = newState;
            ExecuteStateChange();
        }


        /* PROBAR PARA MANEAR LOS FORM DESDE EL STORE*/
        public LoginDto GetFormLogin()
        {
            return this._state.LoginDto;
        }
        /* PROBAR PARA MANEAR LOS FORM DESDE EL STORE*/


        #endregion Metodos para obtener y setear los States



        #region Listeners Patron Observer || Gestion de eventos


        // Actua como controlador de eventos.
        private Action _listeners; 

        // Permite subscribirnos a una accion.
        public void AddStateChangeListeners(Action listener) => this._listeners += listener;

        // Permite desubscribirnos a una accion.
        public void RemoveStateChangeListeners(Action listener) => this._listeners -= listener;

        // Invocamos la accion 
        private void ExecuteStateChange() => this._listeners.Invoke();


        #endregion
        /// Nota: Debemos inyectar la dependencia dentro de los Services de Program.cs
    }
}
