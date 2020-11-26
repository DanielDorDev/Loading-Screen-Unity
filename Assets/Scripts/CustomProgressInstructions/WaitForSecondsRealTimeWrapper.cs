using UnityEngine;

namespace Bailfie.LoadingScreen.Utility
{
    public class WaitForSecondsRealTimeWrapper : CustomYieldProgressInstruction
    {
        readonly float _waitForSecondsRealTime;
        float _targetTime;
        bool yielding;
        public WaitForSecondsRealTimeWrapper(float seconds)
        {
            _waitForSecondsRealTime = seconds;
            yielding = false;
        }
        public override float Progress => Mathf.InverseLerp(_waitForSecondsRealTime, 0 , _targetTime - Time.realtimeSinceStartup);

        public override bool keepWaiting
        {
            get
            {

                if(!yielding)
                {
                    _targetTime = _waitForSecondsRealTime + Time.realtimeSinceStartup;
                    yielding = true;
                }
                else if (_targetTime <= Time.realtimeSinceStartup)
                {
                    yielding = false;
                }

                return yielding;

            }
        }

    }
}