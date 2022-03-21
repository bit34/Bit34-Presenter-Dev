using Com.Bit34Games.Director.Signaling;

namespace MyGame.Character.Signals
{
    public class CharacterSelectedSignal : Signal<int/*prevCharacterId*/,int/*newCharacterId*/>{}
}