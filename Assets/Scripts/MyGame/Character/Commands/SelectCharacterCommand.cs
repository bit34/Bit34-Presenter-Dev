using MyGame.Character.Models;
using MyGame.Character.Signals;

namespace MyGame.Characer.Commands
{
    public class SelectCharacterCommand : SelectCharacterSignal.Command
    {
        //  MEMBERS
#pragma warning disable 0649
        //      Models
        [Inject] private CharactersModel _charactersModel;
        //      Signals to dispatch
        [Inject] private CharacterSelectedSignal _characterSelectedSignal;
#pragma warning restore 0649

        //  METHODS
        protected override void ExecuteMethod(int characterId)
        {
            int prevCharacterId = _charactersModel.SelectedCharacterId;
            _charactersModel.SetSelectedCharacter(characterId);

            _characterSelectedSignal.Dispatch(prevCharacterId, characterId);
        }
    }
}