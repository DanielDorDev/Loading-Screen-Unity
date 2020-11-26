using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Example of using progress yield controller, to perform different operations on loading screen
/// Example of fading in, out, and progress bar update.
/// </summary>
[RequireComponent(typeof(CanvasGroup))]
public class CanvasGroupYieldRender : MonoBehaviour
{
    [SerializeField] private ProgressYieldController _customYieldProgressController;

    // Perform operation on attached canvas group
    private CanvasGroup _cacheCanvasGroup;

    //
    [SerializeField] private Slider slider = default;
    void Awake()
    {
        _cacheCanvasGroup = GetComponent<CanvasGroup>();
    }
    
    public void ChangeSliderValue()
    {
        slider.value = _customYieldProgressController.progress;
    }

    /// <summary>
    /// Preform 
    /// </summary>
    /// <param name="customYieldProgress"></param>
    /// <returns></returns>
    public IEnumerator LoadScreen(LoadingScreen.Utility.ProgressYieldInstruction customYieldProgress)
    {
        yield return _customYieldProgressController.CustomYieldSuspend(customYieldProgress);
    }

}
