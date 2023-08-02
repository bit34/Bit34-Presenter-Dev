using Com.Bit34Games.Director.Mediation;
using Com.Bit34Games.Director.Signaling;
using Com.Bit34Games.Injector;
using MyGame.Main.Commands;
using MyGame.Main.Signals;
using MyGame.Main.Unity;
using MyGame.Main.Views;

namespace MyGame.Main.Context
{
    public static class MainContextBindings
    {
        public static void AddBindings(InjectorContext injector, MediationBinder mediationBinder, SignalCommandBinder signalCommandBinder)
        {
            signalCommandBinder.BindSignal<LoadDataSignal>()        .ToCommand<LoadDataCommand>();
            signalCommandBinder.BindSignal<DataLoadedSignal>();

            mediationBinder.BindView<MainScreenView>()              .ToMediator<MainScreenMediator>()               .As<IMainScreenView>();
        }
    }
}