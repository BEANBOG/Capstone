using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCode0 : MonoBehaviour
{
    public GameObject wall;
    public BoxDetection script;
      
    void Update()
    {
        if(script.cleared1 == 1)
        {
             wall.SetActive(false);
        }
    }
}
