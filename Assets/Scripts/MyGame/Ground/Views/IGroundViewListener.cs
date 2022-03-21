using UnityEngine;

namespace MyGame.Ground.Views
{
    public interface IGroundViewListener
    {
        void OnViewLeftClicked();
        void OnViewRightClicked(Vector3 worldPosition);
    }
}