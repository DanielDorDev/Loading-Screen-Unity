using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class CanvasGroupYieldRender : MonoBehaviour
{
    private CustomYieldProgressController _customYieldProgressController;
    private CanvasGroup _cacheCanvasGroup;
    [SerializeField] private Slider slider;
    void Awake()
    {
        _cacheCanvasGroup = GetComponent<CanvasGroup>();
        _customYieldProgressController = new CustomYieldProgressController();

        _customYieldProgressController.OnStart += () => _cacheCanvasGroup.interactable = false;
        _customYieldProgressController.OnCustomEvent += (float value) => slider.value = value;
        _customYieldProgressController.OnFinish += () => _cacheCanvasGroup.interactable = true;
    }

    public IEnumerator LoadScreen(Bailfie.LoadingScreen.Utility.CustomYieldProgressInstruction customYieldProgress)
    {
        yield return _customYieldProgressController.CustomYieldRender(customYieldProgress);
    }

}
