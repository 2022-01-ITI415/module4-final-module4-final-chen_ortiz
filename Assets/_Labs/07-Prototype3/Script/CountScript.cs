using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountScript : MonoBehaviour
{
    public TextMeshProUGUI CountText;
    public static int count;

    void Start()
    {
        count = 0;
    }
    void Update()
    {
        CountText.text = "Coins: " + count;
    }
}
