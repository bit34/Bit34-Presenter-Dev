using UnityEngine;

namespace MyGame.Main.Unity
{
    public class ResourceRefs : MonoBehaviour
    {
        //  MEMBERS
        public GameObject MainScreenViewPrefab       { get { return _mainScreenViewPrefab; } }
        public GameObject CharacterOverlayViewPrefab { get { return _characterOverlayViewPrefab; } }
        public GameObject CharactersViewPrefab       { get { return _charactersViewPrefab; } }
        //      For Editor
#pragma warning disable 0649
        [Header("UI resources")]
        [SerializeField] private GameObject _mainScreenViewPrefab;
        [SerializeField] private GameObject _characterOverlayViewPrefab;
        [Header("World resources")]
        [SerializeField] private GameObject _charactersViewPrefab;
#pragma warning restore 0649
    }
}