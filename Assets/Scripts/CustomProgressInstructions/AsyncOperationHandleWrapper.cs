/*using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Bailfie.LoadingScreen.Utility
{
    public class AsyncOperationHandleWrapper : CustomYieldProgressInstruction
    {
        private float _downloadSize;
        protected AsyncOperationHandle _operation;
        public override float Progress => _operation.PercentComplete / 100f;

        public override bool keepWaiting => _operation.IsDone;

        public AsyncOperationHandleWrapper(AsyncOperationHandle operation)
        {
            _operation = operation;
            _downloadSize = _operation.GetDownloadStatus().TotalBytes;
        }
        public override float ProgressInterpolated(float value) => Mathf.Lerp(0, _downloadSize, value);
    }
}*/