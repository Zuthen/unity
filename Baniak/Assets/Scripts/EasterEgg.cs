﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasterEgg : MonoBehaviour
{
        public void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Games Room Fight");
    }
}