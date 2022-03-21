using System.Collections.Generic;
using UnityEngine;
using MyGame.Character.Models.VO;

namespace MyGame.Character.Models
{
    public class CharactersModel
    {
        //  MEMBERS
        public int CharacterCount { get{ return _items.Count; } }
        public int SelectedCharacterId { get; private set; }
        //      Internal
        private Dictionary<int, CharacterVO> _items;

        //  CONSTRUCTORS
        public CharactersModel()
        {
            _items = new Dictionary<int, CharacterVO>();
        }

        //  METHODS
        public void AddCharacter(int id, string name, Vector3 position)
        {
            _items.Add(id, new CharacterVO(id,  name, position));
        }

        public CharacterVO GetCharacter(int id)
        {
            return _items[id];
        }

        public IEnumerator<CharacterVO> GetCharacters()
        {
            return _items.Values.GetEnumerator();
        }

        public void SetSelectedCharacter(int characterId)
        {
            SelectedCharacterId = characterId;
        }
    }
}
