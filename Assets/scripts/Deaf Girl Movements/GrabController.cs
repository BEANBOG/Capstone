using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabController : MonoBehaviour
{

    public Transform grabDetect;
    public Transform boxHolder;
    public float rayDistance;

    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDistance);

        if (grabCheck.collider != null && grabCheck.collider.tag == "Box1")
        {
            if (Input.GetKey(KeyCode.E))
            {
                grabCheck.collider.gameObject.transform.parent = boxHolder;
                grabCheck.collider.gameObject.transform.position = boxHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            }
            else
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }

        }

        if (grabCheck.collider != null && grabCheck.collider.tag == "Box1")
        {
            if (Input.GetKey(KeyCode.T))
            {
                SceneManager.LoadScene("deaf code");
            }
        }

        if (grabCheck.collider != null && grabCheck.collider.tag == "light")
        {
            if (Input.GetKey(KeyCode.E))
            {
                grabCheck.collider.gameObject.transform.parent = boxHolder;
                grabCheck.collider.gameObject.transform.position = boxHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            }
            else
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }

        }


        if (grabCheck.collider != null && grabCheck.collider.tag == "Box2")
        {
            if (Input.GetKey(KeyCode.E))
            {
                grabCheck.collider.gameObject.transform.parent = boxHolder;
                grabCheck.collider.gameObject.transform.position = boxHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            }
            else
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
        //// new
        if (grabCheck.collider != null && grabCheck.collider.tag == "Bathroom")
        {
            if (Input.GetKey(KeyCode.J))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(3);
                Debug.Log("open");
            }

        }

    }
}
