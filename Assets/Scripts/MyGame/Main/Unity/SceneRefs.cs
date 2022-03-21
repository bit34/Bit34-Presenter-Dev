using UnityEngine;

namespace MyGame.Main.Unity
{
    public class SceneRefs : MonoBehaviour
    {
        //  MEMBERS
        public Transform  UIContainer    { get { return _uiContainer;    } }
        public Transform  WorldContainer { get { return _worldContainer; } }
        //      For Editor
#pragma warning disable 0649
        [SerializeField] private Transform _uiContainer;
        [SerializeField] private Transform _worldContainer;
#pragma warning restore 0649
    }
}