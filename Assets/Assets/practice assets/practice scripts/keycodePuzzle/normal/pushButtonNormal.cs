using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class pushButtonNormal : MonoBehaviour
{
    public AudioSource buttonPushed;

    public static event Action<string> ButtonPressedNormal = delegate { };
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
        ButtonPressedNormal(buttonValue);
        buttonPushed.Play();
    }
}
