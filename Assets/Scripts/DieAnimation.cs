using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ParticleSystem>().Play();
        Destroy(gameObject, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
