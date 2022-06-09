using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour
{
    public GameObject Player1, Player2;

    int whichAvatarIsOn = 1;
    private void Start()
    {
        Player1.gameObject.SetActive(true);
        Player2.gameObject.SetActive(false);
    }

    void update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            print("pressed");
        {     
            if(whichAvatarIsOn == 2)
        {
            Player1.gameObject.SetActive(false);
            Player2.gameObject.SetActive(true);
                whichAvatarIsOn = whichAvatarIsOn - 1;
        }

        if (whichAvatarIsOn == 1)
        {
            Player1.gameObject.SetActive(true);
            Player2.gameObject.SetActive(false);
                whichAvatarIsOn = whichAvatarIsOn + 1;
            }

        }
            

    }
}
