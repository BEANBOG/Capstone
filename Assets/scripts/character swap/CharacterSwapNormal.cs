using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwapNormal : MonoBehaviour
{

    public GameObject otherPlayer;
    int active = 1;
    int counter = 1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            charSwap();
            active = counter;

        }
    }

    private void charSwap()
    {


        if (active == 1)
        {
            otherPlayer.GetComponent<DeafMovement>().enabled = false;
            GetComponent<PlayerMovement>().enabled = true; ;
            counter = 2;
        }

        if (active == 2)
        {
            otherPlayer.GetComponent<DeafMovement>().enabled = true;
            GetComponent<PlayerMovement>().enabled = false;
            counter = 1;
        }

    }
}
