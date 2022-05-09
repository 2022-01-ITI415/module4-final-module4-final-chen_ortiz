using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScript : MonoBehaviour
{
   public GameObject countText;
   public int theCount;
   public AudioSource Sound;

   void OnTriggerEnter(Collider other)
   {
       Sound.Play();
       theCount += 1;
       countText.GetComponent<Text>().text = "COINS: " + theCount;
       Destroy(gameObject);
   }
}
