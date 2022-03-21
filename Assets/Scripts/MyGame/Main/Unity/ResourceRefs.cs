using UnityEngine;

namespace MyGame.Main.Unity
{
    public class ResourceRefs : MonoBehaviour
    {
        //  MEMBERS
        public GameObject CharacterDetailViewPrefab { get { return _characterDetailViewPrefab; } }
        public GameObject CharactersViewPrefab      { get { return _charactersViewPrefab; } }
        //      For Editor
#pragma warning disable 0649
        [Header("UI resources")]
        [SerializeField] private GameObject _characterDetailViewPrefab;
        [Header("World resources")]
        [SerializeField] private GameObject _charactersViewPrefab;
#pragma warning restore 0649
    }
}