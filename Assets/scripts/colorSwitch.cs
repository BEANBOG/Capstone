using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSwitch : MonoBehaviour
{
    // Start is called before the first frame update

    private Renderer rend;

    [SerializeField]
    private Color colorToTurnTo = Color.green;

    private void Start()
    {
        rend = GetComponent<Renderer>();

        rend.material.color = colorToTurnTo;
    }
}
