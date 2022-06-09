using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fslBook : MonoBehaviour
{
    [SerializeField] GameObject book;
    [SerializeField] GameObject page;
    int active = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if(active == 1)
            {
                book.SetActive(false);
                active = 2;
            }

        }
    }
}
