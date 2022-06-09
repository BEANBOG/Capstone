using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDetection : MonoBehaviour
{
    public int cleared1 = 0;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Box1"))
        {
            Debug.Log("Box in range");
            collider.gameObject.GetComponent<SpriteRenderer>().material.color = Color.green;
            cleared1 = 1;
        }

    }
}
