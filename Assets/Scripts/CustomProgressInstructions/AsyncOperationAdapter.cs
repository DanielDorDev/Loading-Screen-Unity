using UnityEngine;

namespace LoadingScreen.Utility
{
    /// <summary>
    /// Allows AsyncOperation to be used as a ProgressYieldInstruction
    /// </summary>
    public class AsyncOperationAdapter : ProgressYieldInstruction
    {
        protected AsyncOperation _operation;
        public override float Progress => _operation.progress;
        public override bool keepWaiting => !_operation.isDone;
        public AsyncOperationAdapter(AsyncOperation operation)
            => _operation = operation;
    }

}
