using UnityEngine.Networking;

namespace LoadingScreen.Utility
{
    /// <summary>
    /// Allows UnityWebRequestAsyncOperation to be used as a ProgressYieldInstruction
    /// </summary>
    public class UnityWebRequestAsyncOperationAdapter : ProgressYieldInstruction
    {
        protected UnityWebRequestAsyncOperation _operation;
        public override float Progress => _operation.progress;
        public override bool keepWaiting => !_operation.isDone;
        public UnityWebRequestAsyncOperationAdapter(UnityWebRequestAsyncOperation operation)
        {
             _operation = operation;
        }
    }
}