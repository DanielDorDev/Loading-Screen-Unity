using UnityEngine;
namespace LoadingScreen.Utility
{
    /// <summary>
    /// Extends the 'CustomYieldInstruction' class
    /// </summary>
    public abstract class ProgressYieldInstruction : CustomYieldInstruction
    {
        /// <summary>
        /// Progress completed, must be in the range [0,1]
        /// </summary>
        public abstract float Progress
        {
            get;
        }

        /// <summary>
        /// Wraps the keepWaiting, for a more readable API
        /// </summary>
        public bool isDone
        {
            get => !keepWaiting;
        }
    }
}