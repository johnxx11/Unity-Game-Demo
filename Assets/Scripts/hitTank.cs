using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitTank : MonoBehaviour
{

    public AudioClip hit;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cactus1" || other.tag == "Cactus1")
        {
            GetComponent<AudioSource>().clip = hit;
            GetComponent<AudioSource>().Play();

        }
    }




}
