using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDetection1 : MonoBehaviour
{
    public int cleared2 = 0;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Box2"))
        {
            Debug.Log("Box in range");
            collider.gameObject.GetComponent<SpriteRenderer>().material.color = Color.red;
            cleared2 = 1;
        }

    }
}
