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
                ShowLoader = false,
                MessageModal = new ModalModels(),
                User = new UserModels(),
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


        public bool IsShowLoader() => this._stateGlobal.ShowLoader;
        public void SetShowLoader(bool newState)
        {
            this._stateGlobal.ShowLoader = newState;
            ExecuteStateChange();
        }


        public bool IsShowMessageModal() => this._stateGlobal.MessageModal.ShowModal;
        public void SetShowMessageModal(bool newState)
        {
            this._stateGlobal.MessageModal.ShowModal = newState;
            ExecuteStateChange();
        }


        public string GetMessageModal() => this._stateGlobal.MessageModal.Message;
        public void SetMessageModal(string newState)
        {
            this._stateGlobal.MessageModal.Message = newState;
            ExecuteStateChange();
        }


        #endregion Metodos para obtener y setear los States



        #region Listeners Patron Observer || Gestion de eventos

        private Action OnStateChange;

        public void SubscribeChangedState(Action listenerComponent) => this.OnStateChange += listenerComponent;

        public void DesubscribeChangedState(Action listenerComponent) => this.OnStateChange -= listenerComponent;

        private void ExecuteStateChange() => this.OnStateChange.Invoke();


        #endregion

        /// Nota: Debemos inyectar la dependencia dentro de los Services de Program.cs
    }
}