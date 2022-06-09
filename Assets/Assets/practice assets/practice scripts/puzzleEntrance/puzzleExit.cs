using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puzzleExit : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Deaf")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

        if (collision.gameObject.tag == "Normal")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
