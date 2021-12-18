using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireRocket : MonoBehaviour
{
    public GameObject rocket;
    float speed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space))
     {
         Instantiate(rocket, transform.position, transform.rotation);
         rocket.transform.Translate(speed * Vector3.forward * Time.deltaTime);
     }
    }
}
