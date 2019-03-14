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
        [SerializeField] float _duration = 7;
        public bool run = true;
        public bool running = false;
        [SerializeField] SplineAnchor _anchor;

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
            _anchor.transform.Translate(Time.deltaTime/10.0f, 0, 0);
            //_anchor.transform.localPosition = new Vector3(1, 0, 1);
            if (run)
            {
                if (!running)
                {
                    //_anchor.transform.Translate(0, 0, Time.deltaTime);
                    //_anchor.transform.position.x += 0.1;
                    Tween.Spline(_spline, transform, 0, 1, true, _duration, 0, Tween.EaseLinear, Tween.LoopType.Loop);
                    running = true;
                }
            }
            if(!run)
            {
                running = false;
                Tween.Spline(_spline, transform, 0, 0, true, 0, 0, Tween.EaseLinear, Tween.LoopType.Loop);                
            }
        }
    }
}
