using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rotationPuzzleSolution : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject nextRoom;

    public static bool youWin;

    private void Start()
    {
        nextRoom.SetActive(false);
        youWin = false;
    }

    private void Update()
    {
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0)
        {
            youWin = true;
            nextRoom.SetActive(true);
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

        }
    }
}
