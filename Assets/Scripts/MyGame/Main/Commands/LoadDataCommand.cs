using UnityEngine;
using MyGame.Character.Models;
using MyGame.Main.Signals;

namespace MyGame.Main.Commands
{
    public class LoadDataCommand : LoadDataSignal.Command
    {
        //  MEMBERS
#pragma warning disable 0649
        //      Models
        [Inject] private CharactersModel _charactersModel;
        //      Signals to dispatch
        [Inject] private DataLoadedSignal _dataLoadedSignal;
#pragma warning restore 0649

        //  METHODS
        protected override void ExecuteMethod()
        {
            _charactersModel.AddCharacter(_charactersModel.CharacterCount, "Mary", new Vector3(-2.5f, 0.0f,  1.0f));
            _charactersModel.AddCharacter(_charactersModel.CharacterCount, "Anny", new Vector3( 2.0f, 0.0f, -0.5f));

            _dataLoadedSignal.Dispatch();
        }
    }
}