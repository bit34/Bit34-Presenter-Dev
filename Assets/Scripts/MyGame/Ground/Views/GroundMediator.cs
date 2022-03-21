using UnityEngine;
using Com.Bit34Games.Director.Mediation;
using MyGame.Character.Models;
using MyGame.Character.Signals;

namespace MyGame.Ground.Views
{
    public class GroundMediator : IMediator, IGroundViewListener
    {
        //  MEMBERS
#pragma warning disable 0649
        //      View
        [Inject] private IGroundView _view;
        //      Models
        [Inject] private CharactersModel _charactersModel;
        //      Signals to dispatch
        [Inject] private SelectCharacterSignal _selectCharacterSignal;
        [Inject] private MoveCharacterSignal   _moveCharacterSignal;
#pragma warning restore 0649

        //  METHODS
#region MediatorBase implementation
    
        public void OnRegister()
        {
            _view.Initialize(this);
        }

        public void OnRemove()
        {
        }

#endregion

#region Signal listeners

#endregion

#region IGroundViewListener implementation
    
        public void OnViewLeftClicked()
        {
            _selectCharacterSignal.Dispatch(-1);
        }

        public void OnViewRightClicked(Vector3 worldPosition)
        {
            if (_charactersModel.SelectedCharacterId != -1)
            {
                _moveCharacterSignal.Dispatch(_charactersModel.SelectedCharacterId, worldPosition);
            }
        }

#endregion

    }
}
