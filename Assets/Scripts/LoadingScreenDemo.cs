using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoadingScreen.Utility;
public class LoadingScreenDemo : MonoBehaviour
{
    public CanvasGroupYieldRender render;
    IEnumerator Start()
    {
        yield return render.LoadScreen(new WaitForSecondsRealTimeAdapter(new WaitForSecondsRealtime(3)));
    }
}
