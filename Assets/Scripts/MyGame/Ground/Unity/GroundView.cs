using UnityEngine;
using Com.Bit34Games.Unity.Director;
using MyGame.Ground.Views;

namespace MyGame.Ground.Unity
{
    public class GroundView : MonoBehaviourView, IGroundView
    {
        //  MEMBERS
#pragma warning disable 0649
        //      For Editor
#pragma warning restore 0649
        //      Intenal
        private IGroundViewListener _viewListener;

        //  METHODS
        public void Initialize(IGroundViewListener viewListener)
        {
            _viewListener = viewListener;
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _viewListener.OnViewLeftClicked();
            }
            else
            if (Input.GetMouseButtonDown(1))
            {
                Plane plane = new Plane(Vector3.up, 0);
                float distance;
                Ray   ray   = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (plane.Raycast(ray, out distance))
                {
                    Vector3 worldPosition = ray.GetPoint(distance);
                    _viewListener.OnViewRightClicked(worldPosition);
                }
            }
        }

    }
}
