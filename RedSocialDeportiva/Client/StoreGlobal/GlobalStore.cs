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
            _stateGlobal = new GlobalState
            {
                User = new UserModels(),
                IsLoader = false,
                MessageModal = "",
            };
        }

        #endregion


        #region Metodos para obtener y setear los States

        public UserModels GetMyUserData() => _stateGlobal.User;
        public void SetMyUserData(UserModels newState)
        {
            _stateGlobal.User = newState;
            ExecuteStateChange();
        }

        
        public bool IsLoader() => _stateGlobal.IsLoader;
        public void SetIsLoader(bool newState)
        {
            _stateGlobal.IsLoader = newState;
            ExecuteStateChange();
        }


        public string MessageModal() => _stateGlobal.MessageModal;
        public void SetMessageModal(string newState)
        {
            _stateGlobal.MessageModal = newState;
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