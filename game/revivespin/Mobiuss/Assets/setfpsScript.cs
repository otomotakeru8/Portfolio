﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setfpsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 120;
    }

    // Update is called once per frame
    void Update()
    {
        float fps = 1/Time.deltaTime;
        Debug.Log(fps);
    }
}
