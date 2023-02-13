using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameoversound : MonoBehaviour
{
    public AudioSource soundover;

    void OnTriggerEnter(Collider other)
    {
        soundover.Play();
        
    }
}
