using UnityEngine;

namespace MyGame.Character.Views
{
    public interface ICharactersView
    {
        //  METHODS
        void Initialize(ICharactersViewListener viewListener);
        void AddCharacter(int id, string name, Vector3 position);
        void UnselectCharacter(int id);
        void SelectCharacter(int id);
        void MoveCharacter(int id, Vector3 newPosition);
    }
}
