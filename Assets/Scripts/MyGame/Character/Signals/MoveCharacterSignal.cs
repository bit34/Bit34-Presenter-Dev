using UnityEngine;
using Com.Bit34Games.Director.Signaling;

namespace MyGame.Character.Signals
{
    public class MoveCharacterSignal : Signal<int/*characterId*/, Vector3/*newPosition*/>{}
}