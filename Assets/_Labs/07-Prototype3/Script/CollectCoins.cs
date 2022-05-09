using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoins : MonoBehaviour
{
    public TextMeshProUGUI CountText;
    public GameObject winTextObject;
    private int theCount;

    public AudioSource Sound;
    void Start()
    {
        theCount = 0;
    
        SetCountText();
        winTextObject.SetActive(false);
   }

   void SetCountText()
    {
       CountText.text = "Coins: " + theCount.ToString();
       if(theCount>= 50)
       {
           winTextObject.SetActive(true);
       }
    }

   private void OnTriggerEnter(Collider other)
    {
        Sound.Play();

       if(other.gameObject.CompareTag("PickUp"))
       {
        other.gameObject.SetActive(false);
        theCount = theCount + 1;

        SetCountText();
       }
       Destroy(gameObject);
    }
}
