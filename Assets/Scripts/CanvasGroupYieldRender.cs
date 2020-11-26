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
    [SerializeField] private Slider slider = default;
    
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
