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

    void Start()
    {

        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }

    private void Update()
    {
        active = counter;
    }

    // Start is called before the first frame update
    private void ButtonClicked()
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
