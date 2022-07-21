using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwapNormal : MonoBehaviour
{

    public GameObject otherPlayer;
    public GameObject otherPlayerGlow;
    public GameObject playerGlow;
    int active = 1;
    int counter = 1;
    private void Start()
    {
        playerGlow.SetActive(false);
        otherPlayerGlow.SetActive(false);

    }
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
            GetComponent<PlayerMovement>().enabled = true;
            playerGlow.SetActive(true);
            otherPlayerGlow.SetActive(false);

            counter = 2;
        }

        if (active == 2)
        {
            otherPlayer.GetComponent<DeafMovement>().enabled = true;
            GetComponent<PlayerMovement>().enabled = false;
            playerGlow.SetActive(false);
            otherPlayerGlow.SetActive(true);

            counter = 1;
        }

    }
}
