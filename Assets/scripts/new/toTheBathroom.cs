using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toTheBathroom : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Deaf" )
        {

            if (collision.gameObject.tag == "Normal")
            {

            
            }
                
            

        }
    }

 
}
