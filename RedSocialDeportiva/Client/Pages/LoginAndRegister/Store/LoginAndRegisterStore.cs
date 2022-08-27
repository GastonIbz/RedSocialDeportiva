namespace RedSocialDeportiva.Client.Pages.LoginAndRegister.Store
{
    public class LoginAndRegisterStore
    {

        private LoginAndRegisterState _state;

        public LoginAndRegisterStore()
        {
            this._state = new LoginAndRegisterState
            {
                LoginActive = true,
                RegisterActive = false,
                ClassCssForm = "",
                LoginDto = new DataLoginDTO(),
                RegisterDto = new DataRegisterDTO()
            };
        }


        #region Metodos para obtener y setear los States


        public bool IsLoginActive() => this._state.LoginActive;
        public void SetLoginActive(bool newState)
        {
            this._state.LoginActive = newState;
            this.ChangeClassCssForm();
            ExecuteStateChange();
        }


        public bool IsRegisterActive() => this._state.RegisterActive;
        public void SetRegisterActive(bool newState)
        {
            this._state.RegisterActive = newState;
            this.ChangeClassCssForm();
            ExecuteStateChange();
        }


        public DataLoginDTO GetFormLogin() => this._state.LoginDto;
        public void ResetFormLogin() 
        {
            this._state.LoginDto = new DataLoginDTO();
            ExecuteStateChange();
        }


        public DataRegisterDTO GetFormRegister() => this._state.RegisterDto;
        public void ResetFormRegister()
        {
            this._state.RegisterDto = new DataRegisterDTO();
            ExecuteStateChange();
        }


        public string GetClassCssFormModifed() => this._state.ClassCssForm;
        public void ChangeClassCssForm()
        {
            if (this._state.LoginActive && !this._state.RegisterActive)
            {
                this._state.ClassCssForm = "containerPage__LoginAndRegister--loginActive";
            }
            else
            {
                this._state.ClassCssForm = "containerPage__LoginAndRegister--registerActive";
            }
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
