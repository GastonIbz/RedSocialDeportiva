namespace RedSocialDeportiva.Client.StoreGlobal
{

    public class GlobalStore
    {

        #region State
        private GlobalState _stateGlobal;
        #endregion

        #region CONSTRUCTOR

        public GlobalStore()
        {
            this._stateGlobal = new GlobalState
            {
                User = new UserModels(),
                IsLoader = false,
                MessageModal = "",
            };
        }

        #endregion


        #region Metodos para obtener y setear los States

        public UserModels GetMyUserData() => this._stateGlobal.User;
        public void SetMyUserData(UserModels newState)
        {
            this._stateGlobal.User = newState;
            ExecuteStateChange();
        }

        
        public bool IsLoader() => this._stateGlobal.IsLoader;
        public void SetIsLoader(bool newState)
        {
            this._stateGlobal.IsLoader = newState;
            ExecuteStateChange();
        }


        public string MessageModal() => this._stateGlobal.MessageModal;
        public void SetMessageModal(string newState)
        {
            this._stateGlobal.MessageModal = newState;
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