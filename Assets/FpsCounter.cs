﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FpsCounter : MonoBehaviour
{
    public int avgFrameRate;
    public Text display_Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float current = 0;
        current = (int)(1f / Time.unscaledDeltaTime); ;
        avgFrameRate = (int)current;
        display_Text.text = "FPS: " + avgFrameRate.ToString();
    }
}
