using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class FadeLoadingScreen : MonoBehaviour
{

    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] [Range(0, 5)] private float fadeTime = 0.5f;

    IEnumerator Fade(bool fadeAway)
    {

        for (float t = 0; t < 1.0f; t += Time.deltaTime / fadeTime)
        {
            float alphaInterpolate = Mathf.Lerp(0, 1, t);
            canvasGroup.alpha = fadeAway ? 1 - alphaInterpolate : alphaInterpolate;
            yield return null;
        }
    }
    public void FadeIn()
    {
        StartCoroutine(Fade(false));
    }
    public void FadeOut()
    {
        StartCoroutine(Fade(true));

    }

}
