using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScene : MonoBehaviour
{
    public FadeIn fade;

    public void OnTriggerEnter(Collider other)
    {
       
       
        fade.fadeOut();
        SceneManager.LoadScene("Island");
    }
    

    // Start is called before the first frame update
    void Start()
    {
        fade.fadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
