using Com.Bit34Games.Director.Mediation;
using Com.Bit34Games.Director.Signaling;
using Com.Bit34Games.Injector;
using MyGame.Characer.Commands;
using MyGame.Character.Models;
using MyGame.Character.Unity;
using MyGame.Character.Signals;
using MyGame.Character.Views;

namespace MyGame.Character.Context
{
    public static class CharacterContextBindings
    {
        public static void AddBindings(InjectorContext injector, MediationBinder mediationBinder, SignalCommandBinder signalCommandBinder)
        {
            //  Model bindings
            injector.AddBinding<CharactersModel>()                      .ToType<CharactersModel>();

            //  View-Mediator bindings
            mediationBinder.BindView<CharactersView>()                  .ToMediator<CharactersMediator>()           .As<ICharactersView>();
            mediationBinder.BindView<CharacterOverlayView>()            .ToMediator<CharacterOverlayMediator>()     .As<ICharacterOverlayView>();

            //  Signal-Command bindings
            signalCommandBinder.BindSignal<SelectCharacterSignal>()     .ToCommand<SelectCharacterCommand>();
            signalCommandBinder.BindSignal<CharacterSelectedSignal>();
            signalCommandBinder.BindSignal<MoveCharacterSignal>()       .ToCommand<MoveCharacterCommand>();
            signalCommandBinder.BindSignal<CharacterMovedSignal>();
        }
    }
}