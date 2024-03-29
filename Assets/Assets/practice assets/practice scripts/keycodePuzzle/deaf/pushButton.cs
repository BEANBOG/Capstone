﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class pushButton : MonoBehaviour
{

    public static event Action<string> ButtonPressed = delegate { };
    private int dividerPosition;
    private string buttonName, buttonValue;

    void Start()
    {
        buttonName = gameObject.name;
        dividerPosition = buttonName.IndexOf("_");
        buttonValue = buttonName.Substring(0, dividerPosition);

        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }

    // Update is called once per frame
    private void ButtonClicked()
    {
        ButtonPressed(buttonValue);
    }
}
