using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCode : MonoBehaviour
{
    public GameObject wall;
    public BoxDetection script;
    public BoxDetection1 script1;
  
    void Update()
    {
        if(script.cleared1 == 1 && script1.cleared2 == 1)
        {
             wall.SetActive(false);
        }
    }
}
