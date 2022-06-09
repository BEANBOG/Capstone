using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwapNormal : MonoBehaviour
{

    public GameObject otherPlayer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            print("normal");


            otherPlayer.GetComponent<DeafMovement>().enabled = false;
            GetComponent<PlayerMovement>().enabled = true;
        }
    }

}
