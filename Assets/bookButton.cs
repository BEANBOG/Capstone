using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class bookButton : MonoBehaviour
{
    [SerializeField] GameObject book;
    [SerializeField] GameObject page;
    int active = 1;
    int counter = 1;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            openBook();
             active = counter;
        }
           
    }

    // Start is called before the first frame update
    private void openBook()
    {

            if (active == 1)
            {
                book.SetActive(true);
                counter = 2;
            }

            if (active == 2)
            {
                book.SetActive(false);
                counter = 1;
            }

    }
}
