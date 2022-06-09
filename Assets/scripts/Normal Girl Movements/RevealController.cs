using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealController : MonoBehaviour
{
    public Transform revealDetect;
    public float rayDist;


    // Update is called once per frame
    void Update()
    {
        RaycastHit2D reveal = Physics2D.Raycast(revealDetect.position, Vector2.right * transform.localScale, rayDist);

        if(reveal.collider != null && reveal.collider.tag == "Box1")
        {
            if(Input.GetKey(KeyCode.Q))
            {
                reveal.collider.GetComponent<SpriteRenderer>().color = Color.green;
            }
        }

        else if(reveal.collider != null && reveal.collider.tag == "Box2")
        {
            if(Input.GetKey(KeyCode.Q))
            {
                reveal.collider.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }
}
