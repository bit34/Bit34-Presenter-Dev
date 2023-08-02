using Com.Bit34Games.Presenter.Views;

namespace MyGame.Main.Views
{
    public class MainScreenMediator : ScreenMediator
    {
        //  MEMBERS
#pragma warning disable 0649
        //      View
        [Inject] private IMainScreenView _view;
        //      Models
        //      Signals to listen
#pragma warning restore 0649

        //  METHODS
#region MediatorBase implementation
    
        protected override void Initialize()
        {
            _view.Initialize();
        }

        protected override void Uninitialize()
        {
        }

#endregion

#region Signal listeners

#endregion

    }
}
