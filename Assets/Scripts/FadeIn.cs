using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{

    public Image BlackFade;

    // Start is called before the first frame update
    public void Start()
    {

        BlackFade.canvasRenderer.SetAlpha(1.0f);
        
    }

    // Update is called once per frame
    public void fadeOut()
    {
        BlackFade.CrossFadeAlpha(1, 2, false);
    }

    public void fadeIn()
    {
        BlackFade.CrossFadeAlpha(0, 3, false);
    }
}
