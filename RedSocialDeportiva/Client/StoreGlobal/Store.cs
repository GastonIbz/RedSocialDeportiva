namespace RedSocialDeportiva.Client.StoreGlobal
{

    public class Store
    {

        #region State
        private GlobalState _stateGlobal;


        #region CONSTRUCTOR

        public Store()
        {
            _stateGlobal = new GlobalState
            {
                User = new UserModels()
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