﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        new WaitForSeconds(1);
        SceneManager.LoadScene("CubeScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
