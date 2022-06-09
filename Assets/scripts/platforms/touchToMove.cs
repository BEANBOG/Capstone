using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchToMove : MonoBehaviour
{
    [SerializeField]
    public Vector3 velocity;

    private bool moving;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            moving = true;
            collision.collider.transform.SetParent(transform);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
      
            if (velocity == new Vector3(1, 0, 0))
            {
            velocity = new Vector3(-1, 0, 0);
            }
            else if (velocity == new Vector3(-1, 0, 0))
            {
            velocity = new Vector3(1, 0, 0);
            }
    
    }


   /* private void movement()
    {
        if (velocity == new Vector3(1,0,0))
        {
            velocity = new Vector3(-1,0,0);
        }
        else if (velocity == new Vector3(-1, 0, 0))
        {
            velocity = new Vector3(1, 0, 0);
        }
    }
    */
 

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(null);
    }

    private void FixedUpdate()
    {
        if(moving)
        {
            transform.position += (velocity * Time.deltaTime);
        }
    }
}
