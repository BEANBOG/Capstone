using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   bool timerActive = false;
   public float currentTime;
   public int startMinutes;
   public Animator animator;

    void Start()
   {
       currentTime = startMinutes * 2;
   }    


    void Update()
    {
        if (timerActive == true)
        {
            currentTime = currentTime - Time.deltaTime;
        }

         if (currentTime <= 0)
       {
           Debug.Log("Destroy");
           gameObject.SetActive(false);
       }

        
    }

    void OnCollisionEnter2D(Collision2D col)
   {
       Debug.Log("Timer");
       StartTimer();
       animator.SetBool("break", true);
    }

    public void StartTimer()
   {
       timerActive = true;
   }
}