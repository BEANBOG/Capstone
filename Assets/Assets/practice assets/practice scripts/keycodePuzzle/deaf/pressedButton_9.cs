using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class pressedButton_9 : MonoBehaviour
{
    [SerializeField]
    private Sprite[] digits;

    [SerializeField]
    private Image[] characters;

    private string codeSequence;

    void Start()
    {
        codeSequence = "";

        for (int i = 0; i <= characters.Length - 1; i++)
        {
            characters[i].sprite = digits[9];
        }
        pushButton.ButtonPressed += addDigitToCodeSequence;

    }

    private void addDigitToCodeSequence(string digitEntered)
    {
        if (codeSequence.Length < 4)
        {
            switch (digitEntered)
            {
                case "Zero":
                    codeSequence += "0";
                    DisplayCodeSequence(0);
                    break;

                case "One":
                    codeSequence += "1";
                    DisplayCodeSequence(1);
                    break;

                case "Two":
                    codeSequence += "2";
                    DisplayCodeSequence(2);
                    break;

                case "Three":
                    codeSequence += "3";
                    DisplayCodeSequence(3);
                    break;

                case "Four":
                    codeSequence += "4";
                    DisplayCodeSequence(4);
                    break;

                case "Five":
                    codeSequence += "5";
                    DisplayCodeSequence(5);
                    break;

                case "Six":
                    codeSequence += "6";
                    DisplayCodeSequence(6);
                    break;

                case "Seven":
                    codeSequence += "7";
                    DisplayCodeSequence(7);
                    break;

                case "Eight":
                    codeSequence += "8";
                    DisplayCodeSequence(8);
                    break;
            }
        }

        switch (digitEntered)
        {
            case "Star":
                resetDisplay();
                break;

            case "Hash":
                if (codeSequence.Length > 0)
                {
                    checkResults();
                }
                break;
        }
    }

    private void DisplayCodeSequence(int digitJustEntered)
    {
        switch (codeSequence.Length)
        {
            case 1:
                characters[0].sprite = digits[9];
                characters[1].sprite = digits[9];
                characters[2].sprite = digits[9];
                characters[3].sprite = digits[digitJustEntered];
                break;

            case 2:
                characters[0].sprite = digits[9];
                characters[1].sprite = digits[9];
                characters[2].sprite = characters[3].sprite;
                characters[3].sprite = digits[digitJustEntered];
                break;

            case 3:
                characters[0].sprite = digits[9];
                characters[1].sprite = characters[2].sprite;
                characters[2].sprite = characters[3].sprite;
                characters[3].sprite = digits[digitJustEntered];
                break;

            case 4:
                characters[0].sprite = characters[1].sprite; ;
                characters[1].sprite = characters[2].sprite; ;
                characters[2].sprite = characters[3].sprite; ;
                characters[3].sprite = digits[digitJustEntered];
                break;
        }
    }

    private void checkResults()
    {
        if (codeSequence == "2104")
        {
            Debug.Log("Correct");
            SceneManager.LoadScene("Stage 1-1.1");

        }
        else
        {
            Debug.Log("Wrong");
            resetDisplay();
        }
    }

    private void resetDisplay()
    {
        for (int i = 0; i <= characters.Length - 1; i++)
        {
            characters[i].sprite = digits[9];
        }

        codeSequence = "";
    }

    private void OnDestroy()
    {
        pushButton.ButtonPressed -= addDigitToCodeSequence;
    }




    // Update is called once per frame
    void Update()
    {

    }
}
