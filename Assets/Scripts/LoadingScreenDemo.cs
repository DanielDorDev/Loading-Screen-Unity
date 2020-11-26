using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bailfie.LoadingScreen.Utility;
public class LoadingScreenDemo : MonoBehaviour
{
    public CanvasGroupYieldRender render;
    // Start is called before the first frame update
    IEnumerator Start()
    {

        var d = new WaitForSecondsRealTimeWrapper(3);
        yield return render.LoadScreen(d);
    }
}
