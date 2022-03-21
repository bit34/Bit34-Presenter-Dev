using Com.Bit34Games.Director.Mediation;
using MyGame.Character.Models;
using MyGame.Character.Models.VO;
using MyGame.Character.Signals;

namespace MyGame.Character.Views
{
    public class CharacterDetailMediator : IMediator
    {
        //  MEMBERS
#pragma warning disable 0649
        //      View
        [Inject] private ICharacterDetailView _view;
        //      Models
        [Inject] private CharactersModel _charactersModel;
        //      Signals to listen
        [Inject] private CharacterSelectedSignal _characterSelectedSignal;
#pragma warning restore 0649

        //  METHODS
#region MediatorBase implementation
    
        public void OnRegister()
        {
            _view.Initialize();
            
            _characterSelectedSignal.AddListener(OnCharacterSelected);
        }

        public void OnRemove()
        {
            _characterSelectedSignal.RemoveListener(OnCharacterSelected);
        }

#endregion

#region Signal listeners

        private void OnCharacterSelected(int prevCharacterId, int newCharacterId)
        {
            if (newCharacterId != -1)
            {
                CharacterVO character = _charactersModel.GetCharacter(newCharacterId);
                _view.SetCharacter(character.name);
            }
            else
            {
                _view.ClearCharacter();
            }
        }

#endregion

    }
}
