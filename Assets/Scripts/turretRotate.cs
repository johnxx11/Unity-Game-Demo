using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretRotate : MonoBehaviour
{
    float moveSpeed = 80.0f;
    float move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        transform.Rotate(0.0f , move * moveSpeed * Time.deltaTime, 0.0f);
            
    }
}
