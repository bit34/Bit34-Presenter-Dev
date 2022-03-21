using Com.Bit34Games.Director.Mediation;
using Com.Bit34Games.Director.Signaling;
using Com.Bit34Games.Injector;
using MyGame.Main.Commands;
using MyGame.Main.Signals;

namespace MyGame.Main.Context
{
    public static class MainContextBindings
    {
        public static void Initialize(InjectorContext injector, MediationBinder mediationBinder, SignalCommandBinder signalCommandBinder)
        {
            //  Signal-Command bindings
            signalCommandBinder.BindSignal<LoadDataSignal>()        .ToCommand<LoadDataCommand>();
            signalCommandBinder.BindSignal<DataLoadedSignal>();
        }
    }
}