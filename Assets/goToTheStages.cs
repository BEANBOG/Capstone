using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToTheStages : MonoBehaviour
{

    public Transform grabDetect;
    public float rayDistance;


    // Update is called once per frame
    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDistance);

        if (grabCheck.collider != null && grabCheck.collider.tag == "Bathroom")
        {
            if (Input.GetKey(KeyCode.E))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(3);
                Debug.Log("open");
            }

        }
    }
}