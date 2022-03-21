using UnityEngine;
using UnityEngine.UI;
using MyGame.Character.Views;

namespace MyGame.Character.Unity
{
    public class CharacterComponent : MonoBehaviour
    {
        //  MEMBERS
#pragma warning disable 0649
        //      For Editor
        [SerializeField] private Text         _nameLabel;
        [SerializeField] private MeshRenderer _renderer;
#pragma warning restore 0649
        //      Intenal
        private ICharactersViewListener _viewListener;
        private int    _id;
        private string _name;
        private bool   _isSelected;

        //  METHODS
        public void Initialize(ICharactersViewListener viewListener, int id, string name, Vector3 position)
        {
            _viewListener = viewListener;
            _id     = id;
            _name   = name;

            name = "Character_" + name;
            transform.position = position;
            _renderer.material.color = Color.green;
            _nameLabel.color = Color.black;

            SetSelection(false);
        }

        public void SetSelection(bool state)
        {
            _isSelected = state;
            if (_isSelected)
            {
                _nameLabel.color = Color.yellow;
                _nameLabel.text  = "<b>" + _name + "</b>";
            }
            else
            {
                _nameLabel.color = Color.black;
                _nameLabel.text  = _name;
            }
        }

        public void SetPosition(Vector3 position)
        {
            transform.position = position;
        }

        private void OnMouseDown()
        {
            _viewListener.OnViewCharacterClicked(_id);
        }
    }
}