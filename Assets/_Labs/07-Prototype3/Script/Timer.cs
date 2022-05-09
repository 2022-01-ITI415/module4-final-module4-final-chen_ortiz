using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
   public TextMeshProUGUI TimerText;
   public int secondsLeft = 60;
   public bool takingAway = false;
   public TextMeshProUGUI TimesUp;

   void Start()
   {
       TimerText.text = "00:" + secondsLeft;
   }

   void Update()
   {
       if (takingAway == false && secondsLeft > 0)
       {
           StartCoroutine(TimerTake());
       }
       else
       {
           if(secondsLeft <=0)
           {
            TimesUp.text = "Times Up!";
           }
       }
   }

   IEnumerator TimerTake()
   {
       takingAway = true;
       yield return new WaitForSeconds(1);
       secondsLeft -= 1;
       if(secondsLeft < 10)
       {
           TimerText.text = "00:0" + secondsLeft;
       }
       else
       {
            TimerText.text = "00:" + secondsLeft;
       }
       takingAway = false;
   }
}
