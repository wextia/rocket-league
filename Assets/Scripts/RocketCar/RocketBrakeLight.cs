﻿using System;
using UnityEngine;

public class RocketBrakeLight : MonoBehaviour
{
    [SerializeField]
    RocketCarMotorController car;

    private Renderer m_Renderer;


    private void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }


    private void Update()
    {
        // enable the Renderer when the car is braking, disable it otherwise.
        m_Renderer.enabled = car.BrakeInput > 0f;
    }
}
