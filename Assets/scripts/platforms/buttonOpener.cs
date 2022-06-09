using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonOpener : MonoBehaviour
{
    [SerializeField]

    GameObject Platform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Platform.GetComponent<platform>().moving = true;
    }

}
