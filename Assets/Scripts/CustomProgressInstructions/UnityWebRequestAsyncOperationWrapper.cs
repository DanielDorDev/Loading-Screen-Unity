using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Bailfie.LoadingScreen.Utility
{
    public class UnityWebRequestAsyncOperationWrapper : CustomYieldProgressInstruction
    {
        private float _downloadSize;
        protected UnityWebRequestAsyncOperation _operation;
        public override float Progress => _operation.progress;
        public override bool keepWaiting => _operation.isDone;
        public UnityWebRequestAsyncOperationWrapper(UnityWebRequestAsyncOperation operation, float downloadSize)
        {
             _operation = operation;
            _downloadSize = downloadSize;
        }

        public override float ProgressInterpolated(float value) => Mathf.Lerp(0, _downloadSize, value);

    }
}