using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationOfPieces : MonoBehaviour
{
    private void OnMouseDown()
    {
        if(!rotationPuzzleSolution.youWin)
        {
            gameObject.transform.Rotate(0f, 0f, 90f);
        }
    }
}