﻿using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void Load(string scene)
    {
        Time.timeScale = 1;
        Application.LoadLevel(scene);
    }
}