using UnityEngine;
using MyGame.Character.Models;
using MyGame.Character.Signals;
using MyGame.Character.Models.VO;

namespace MyGame.Characer.Commands
{
    public class MoveCharacterCommand : MoveCharacterSignal.Command
    {
        //  MEMBERS
#pragma warning disable 0649
        //      Models
        [Inject] private CharactersModel _charactersModel;
        //      Signals to dispatch
        [Inject] private CharacterMovedSignal _characterMovedSignal;
#pragma warning restore 0649

        //  METHODS
        protected override void ExecuteMethod(int characterId, Vector3 newPosition)
        {
            CharacterVO character    = _charactersModel.GetCharacter(characterId);
            Vector3     prevPosition = character.position;
            character.position       = newPosition;

            _characterMovedSignal.Dispatch(characterId, prevPosition, newPosition);
        }
    }
}
