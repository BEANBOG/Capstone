using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwapDeaf : MonoBehaviour
{
    private void Start()
    {
        GetComponent<DeafMovement>().enabled = false;
    }
    public GameObject otherPlayer; 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            print("deaf");
            


            otherPlayer.GetComponent<PlayerMovement>().enabled = false;
            GetComponent<DeafMovement>().enabled = true;
        }



    }
}
