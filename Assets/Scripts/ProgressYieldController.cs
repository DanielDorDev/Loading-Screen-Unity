using System.Collections;
using UnityEngine.Events;
using System;
/// <summary>
/// Example of how to use 'ProgressYieldInstruction'
/// There is a separation between the actions to be performed and the yield time
/// </summary>
[Serializable]
public class ProgressYieldController
{
    public float progress = 0;
    /// <summary>
    /// Execute actions when yield start, finish, and in the progress of the suspension 
    /// </summary>
    public UnityEvent OnStart, OnFinish, OnCustomEvent;
    /// <summary>
    /// Execute yield instruction
    /// </summary>
    /// <param name="customYieldProgress">Custom yield instruction</param>
    public IEnumerator CustomYieldSuspend(LoadingScreen.Utility.ProgressYieldInstruction customYieldProgress)
    {
        progress = 0f;
        OnStart?.Invoke();
        while (customYieldProgress.MoveNext())
        {
            progress = customYieldProgress.Progress;
            OnCustomEvent?.Invoke();
            yield return null;
        }
        progress = 1f;
        OnFinish?.Invoke();
    }
}
