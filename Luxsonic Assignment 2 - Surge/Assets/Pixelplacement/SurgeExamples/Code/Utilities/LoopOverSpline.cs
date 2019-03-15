#pragma warning disable 0649

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

namespace Pixelplacement
{
    public class LoopOverSpline : MonoBehaviour
    {
        //Private Methods:
        [SerializeField] Spline _spline;
        [SerializeField] float _duration = 20;
        public bool run = false;
        public bool running = false;
        [SerializeField] SplineAnchor _anchor;

        public GameObject obj;
        public GameObject rightHand;

        //Init:
        void Awake ()
        {
            /*if (run)
            {
                Tween.Spline(_spline, transform, 0, 1, true, _duration, 0, Tween.EaseLinear, Tween.LoopType.Loop);
            }*/
        }
        void Update()
        {
            _anchor.transform.localPosition = obj.transform.position;
            if ((rightHand.transform.position - obj.transform.position).sqrMagnitude > .01)
            {
                if (!running)
                {
                    Tween.Spline(_spline, transform, 0, 1, false, _duration, 0, Tween.EaseLinear, Tween.LoopType.Loop);
                    running = true;
                }
            }
            else
            {
                running = false;
                Tween.Spline(_spline, transform, 0, 0, true, 0, 0, Tween.EaseLinear, Tween.LoopType.Loop);                
            }
        }
    }
}
