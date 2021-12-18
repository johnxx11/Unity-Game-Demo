using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullabte : MonoBehaviour {

    
    public float moveSpeed = 10f;

    // Use this for initialization
    void Start () {
        Destroy(gameObject, 15f);

    }

    // Update is called once per frame
    void Update () {
        transform.Translate(transform.forward * moveSpeed * Time.deltaTime, Space.World);
	}

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Tank")
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
