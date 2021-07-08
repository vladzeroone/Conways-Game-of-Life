﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreaChanger : MonoBehaviour
{
    Button applyButton;
    Slider slider;

    public static int sizeFromApplyButton = 10;

    private void OnEnable()
    {
        applyButton = GetComponent<Button>();
        slider = GetComponentInParent<Slider>();

        sizeFromApplyButton = (int)slider.value;

        //Debug.Log(sizeFromApplyButton);
    }
/*
    private void Update()
    {
        applyButton.onClick.AddListener(SendSize);
    }

    private void SendSize()
    {
        sizeFromApplyButton = (int)slider.value;
        //Debug.Log("sizeFromApplyButton из SendSize: " + sizeFromApplyButton);
    }
*/
}