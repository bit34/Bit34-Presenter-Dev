using UnityEngine;
using Com.Bit34Games.Director.Signaling;

namespace MyGame.Character.Signals
{
    public class CharacterMovedSignal : Signal<int/*characterId*/,Vector3/*oldPosition*/,Vector3/*newPosition*/>{}
}