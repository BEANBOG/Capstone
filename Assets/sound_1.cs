using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class sound_1 : MonoBehaviour
{

    public AudioSource sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
          if (collision.gameObject.tag == "Normal")
            {
                    sound.Play();
            }
        
    }
}
