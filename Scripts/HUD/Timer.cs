﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    private bool Finished = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Finished)
            return;
        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60). ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }

    public void Finnish()
    {
        
        Finished = true;
        GameObject.Find("Capsule").SendMessage("Finish");
    }
}
