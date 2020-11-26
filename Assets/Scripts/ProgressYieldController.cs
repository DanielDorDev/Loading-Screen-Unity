using System.Collections;
using UnityEngine.Events;

/// <summary>
/// Example of how to use 'ProgressYieldInstruction'
/// There is a separation between the actions to be performed and the yield time
/// </summary>
public class ProgressYieldController
{
    /// <summary>
    /// Execute actions when yield start, finish, and in the progress of the suspension 
    /// </summary>
    public event UnityAction OnStart, OnFinish;
    public event UnityAction<float> OnCustomEvent;
    
    /// <summary>
    /// Execute yield instruction
    /// </summary>
    /// <param name="customYieldProgress">Custom yield instruction</param>
    public IEnumerator CustomYieldSuspend(LoadingScreen.Utility.ProgressYieldInstruction customYieldProgress)
    {
        OnStart?.Invoke();
        while (customYieldProgress.MoveNext())
        {
            OnCustomEvent?.Invoke(customYieldProgress.Progress);
            yield return null;
        }
        OnFinish?.Invoke();
    }
}
