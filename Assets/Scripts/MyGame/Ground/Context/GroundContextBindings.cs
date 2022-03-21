using Com.Bit34Games.Director.Mediation;
using Com.Bit34Games.Director.Signaling;
using Com.Bit34Games.Injector;
using MyGame.Ground.Unity;
using MyGame.Ground.Views;

namespace MyGame.Ground.Context
{
    public static class GroundContextBindings
    {
        public static void Initialize(InjectorContext injector, MediationBinder mediationBinder, SignalCommandBinder signalCommandBinder)
        {
            //  View-Mediator bindings
            mediationBinder.BindView<GroundView>()                      .ToMediator<GroundMediator>()           .As<IGroundView>();
        }
    }
}