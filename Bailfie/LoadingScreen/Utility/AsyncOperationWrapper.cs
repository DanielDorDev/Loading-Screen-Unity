using UnityEngine;

namespace Bailfie.LoadingScreen.Utility
{
    public class AsyncOperationWrapper : CustomYieldProgressInstruction
    {
        protected AsyncOperation _operation;
        public override float Progress => _operation.progress;
        public override bool keepWaiting => _operation.isDone;
        public AsyncOperationWrapper(AsyncOperation operation)
            => _operation = operation;
    }

}
