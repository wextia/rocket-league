﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UITimeManager : MonoBehaviour
{

    Text scoreText;
    GameManager gameManager;

    void Start()
    {
        scoreText = transform.GetChild(0).
            GetComponent<Text>();
        gameManager = GameManager.Instance;
    }



    void Update()
    {
        float timer = gameManager.CurrentPlaytime;
        // Debug.Log(timer);
        int minutes = Mathf.Clamp(Mathf.FloorToInt(timer / 60), 0, int.MaxValue);
        int seconds = Mathf.RoundToInt((int)timer % 60);

        scoreText.text = minutes.ToString() + ":" +
            seconds.ToString("00");
    }
}
