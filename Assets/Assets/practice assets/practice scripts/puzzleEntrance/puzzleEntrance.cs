using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puzzleEntrance : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "Deaf")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }

        if (collision.gameObject.tag == "Normal")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
