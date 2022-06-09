using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class audioChecker : MonoBehaviour
{

    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;

    public static event Action<string> buttonPressedChecker = delegate { };
    private int dividerPosition;
    private string buttonName, buttonValue;

    void Start()
    {

        gameObject.GetComponent<Button>().onClick.AddListener(buttonChecker);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void buttonChecker()
    {
        audio1.Play();
        audio2.PlayDelayed(1.0f);
        audio3.PlayDelayed(2.0f);
        audio4.PlayDelayed(3.0f);


    }


}
