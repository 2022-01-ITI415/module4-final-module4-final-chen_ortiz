using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScript : MonoBehaviour
{
   public GameObject countText;
   public static int theCount;


   void Update()
   {
       countText.GetComponent<Text>().text = "COINS: " + theCount;
   }
}
