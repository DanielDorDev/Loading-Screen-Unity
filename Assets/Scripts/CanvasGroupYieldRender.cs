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
    private ProgressYieldController _customYieldProgressController;

    // Perform operation on attached canvas group
    private CanvasGroup _cacheCanvasGroup;

    //
    [SerializeField] private Slider slider = default;
    void Awake()
    {
        _cacheCanvasGroup = GetComponent<CanvasGroup>();
        _customYieldProgressController = new ProgressYieldController();

        _customYieldProgressController.OnStart += () => _cacheCanvasGroup.interactable = false;
        _customYieldProgressController.OnCustomEvent += (float value) => slider.value = value;
        _customYieldProgressController.OnFinish += () => _cacheCanvasGroup.interactable = true;
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
