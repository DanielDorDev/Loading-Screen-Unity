using UnityEngine;

namespace LoadingScreen.Utility
{
    /// <summary>
    /// Allows WaitForSecondRealTime to be used as a ProgressYieldInstruction
    /// </summary>
    public class WaitForSecondsRealTimeAdapter : ProgressYieldInstruction
    {

        /// <summary>
        /// Suspend the operation until the time provided 
        /// </summary>
        private float _realTimeWhenProceed;

        /// <summary>
        /// Is the Yield Instruction currently being executed
        /// </summary>
        private bool _yielding = false;

        /// <summary>
        /// Amount of seconds to suspend the coroutine
        /// </summary>
        protected readonly float _waitForSecondsRealTime;

        public WaitForSecondsRealTimeAdapter(WaitForSecondsRealtime waitForSecondsRealtime)
        {
            _waitForSecondsRealTime = waitForSecondsRealtime.waitTime;
        }

        /// <summary>
        /// Percentage of time elapsed 
        /// On the remaining time, an inverse interpolation is performed between [Yield time, 0]
        /// </summary>
        public override float Progress => Mathf.InverseLerp(_waitForSecondsRealTime, 0 , _realTimeWhenProceed - Time.realtimeSinceStartup);


        /// <summary>
        /// Keep waiting encapsulate the structure & trigger
        /// </summary>
        public override bool keepWaiting
        {
            get
            {
                // If currently no yield instruction is executed, initialize new one
                if (!_yielding)
                {
                    // Assign target time, up to what real time, suspend the coroutine
                    _realTimeWhenProceed = _waitForSecondsRealTime + Time.realtimeSinceStartup;
                    _yielding = true;
                }
                else if (_realTimeWhenProceed <= Time.realtimeSinceStartup)
                {
                    // If the time passed, stop yield instruction exeuction
                    _yielding = false;
                }
                return _yielding;
            }
        }

    }
}