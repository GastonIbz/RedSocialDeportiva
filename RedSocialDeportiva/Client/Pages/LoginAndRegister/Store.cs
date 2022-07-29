namespace RedSocialDeportiva.Client.Pages.LoginAndRegister
{

    /// Definimos los datos q contendra nuestro State
    public class LoginAndRegisterState
    {
        public bool LoginActive { get; set; }
        public bool RegisterActive { get; set; }
        public bool IsLoader { get; set; }

    }


    // Definimos el store junto al State y los metodos del store
    public class LoginAndRegisterStore
    {

        #region State inicial

        private LoginAndRegisterState _state;
        public LoginAndRegisterStore()
        {
            _state = new LoginAndRegisterState
            {
                LoginActive = true
            };
        }

        #endregion


        #region Metodos


        public bool isLoginActive() => this._state.LoginActive;
        public void SetLoginActive(bool newState)
        {
            this._state.LoginActive = newState;

            ExecuteStateChange();

        }


        #endregion



        #region Listeners Patron Observer


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
