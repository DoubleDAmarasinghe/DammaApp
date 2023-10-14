using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class FramerateManager : MonoBehaviour
{

    private int defaultFPS = 60;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = defaultFPS;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(fpsLevel);
    }



    
}
