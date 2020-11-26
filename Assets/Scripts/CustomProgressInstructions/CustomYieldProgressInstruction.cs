using System;
using UnityEngine;
namespace Bailfie.LoadingScreen.Utility
{
    public abstract class CustomYieldProgressInstruction : CustomYieldInstruction
    {
        public abstract float Progress
        {
            get;
        }
        public bool isDone
        {
            get => !keepWaiting;
        }
        public virtual float ProgressInterpolated(float value) => Mathf.Lerp(0, 1, value);

    }
}