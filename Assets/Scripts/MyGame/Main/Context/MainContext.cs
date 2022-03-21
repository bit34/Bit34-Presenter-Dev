using UnityEngine;
using Com.Bit34Games.Unity.Director;
using MyGame.Character.Context;
using MyGame.Ground.Context;
using MyGame.Main.Unity;
using MyGame.Main.Signals;

namespace MyGame.Main.Context
{
    public class MainContext : DirectorContext
    {
        //  MEMBERS
        //      For Editor
#pragma warning disable 0649
        [SerializeField] private ResourceRefs _resourceRefs;
        [SerializeField] private SceneRefs    _sceneRefs;
#pragma warning restore 0649

        //  METHODS
        private void Start()
        {
            InitializeContext();
            StartContext();
        }

        protected override void InitializeBindings()
        {
            MainContextBindings.Initialize(Injector, MediationBinder, SignalCommandBinder);
            CharacterContextBindings.Initialize(Injector, MediationBinder, SignalCommandBinder);
            GroundContextBindings.Initialize(Injector, MediationBinder, SignalCommandBinder);
        }

        protected override void Launch()
        {
            CreateViews();

            Injector.GetInstance<LoadDataSignal>().Dispatch();
        }

        private void CreateViews()
        {
            GameObject.Instantiate(_resourceRefs.CharacterDetailViewPrefab, _sceneRefs.UIContainer);

            GameObject.Instantiate(_resourceRefs.CharactersViewPrefab,      _sceneRefs.WorldContainer);
        }
        
    }
}
