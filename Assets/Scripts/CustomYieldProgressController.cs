using Bailfie.LoadingScreen.Utility;
using System.Collections;
using UnityEngine.Events;

public class CustomYieldProgressController
{
    public event UnityAction OnStart, OnFinish;
    public event UnityAction<float> OnCustomEvent;

    public IEnumerator CustomYieldRender(CustomYieldProgressInstruction customYieldProgress)
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
