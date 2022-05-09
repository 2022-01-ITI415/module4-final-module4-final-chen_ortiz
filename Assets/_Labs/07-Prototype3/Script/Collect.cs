using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public AudioSource Sound;
    void OnTriggerEnter(Collider other)
    {
        Sound.Play();
        CountScript.count += 1;
        Destroy(gameObject);
    }
}
