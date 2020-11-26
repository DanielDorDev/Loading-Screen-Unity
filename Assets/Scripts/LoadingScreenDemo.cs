using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoadingScreen.Utility;
public class LoadingScreenDemo : MonoBehaviour
{
    public CanvasGroupYieldRender render;
    public float waitTime = 3f;
    public void LoadScreen()
    {
        StartCoroutine(ExecuteYieldInstruction());
    }
    IEnumerator ExecuteYieldInstruction()
    {
        yield return render.LoadScreen(new WaitForSecondsRealTimeAdapter(new WaitForSecondsRealtime(waitTime)));
    }
}
