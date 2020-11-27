


/* Addressables Operation */

/*using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
namespace Bailfie.LoadingScreen.Utility
{
    public class AsyncOperationHandleAdapter : CustomYieldProgressInstruction
    {
        private float _downloadSize;
        protected AsyncOperationHandle _operation;
        public override float Progress => _operation.PercentComplete / 100f;

        public override bool keepWaiting => !_operation.IsDone;

        public AsyncOperationHandleAdapter(AsyncOperationHandle operation)
        {
            _operation = operation;
            _downloadSize = _operation.GetDownloadStatus().TotalBytes;
        }
    }
}*/