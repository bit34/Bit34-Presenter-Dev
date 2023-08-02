using Com.Bit34Games.Presenter.Unity;
using UnityEngine;

namespace MyGame.Main.Unity
{
    public class SceneRefs : MonoBehaviour
    {
        //  MEMBERS
        public PresenterSceneManager PresenterManager { get { return _presenterManager; } }
        public Transform             WorldContainer   { get { return _worldContainer;   } }
        //      For Editor
#pragma warning disable 0649
        [SerializeField] private PresenterSceneManager _presenterManager;
        [SerializeField] private Transform             _worldContainer;
#pragma warning restore 0649
    }
}