using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 8f;
    Vector3 Tank = new Vector3(0f, 0f, 0f);

    public AudioClip DisSound;
    public GameObject Die;
    public GameObject damage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, Tank, speed * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Tank - transform.position),1f);
    }
    
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Rocket")
        {
            speed = 0;
            GetComponent<AudioSource>().clip = DisSound;
            GetComponent<AudioSource>().Play();
            Instantiate(Die,gameObject.transform.position,gameObject.transform.rotation);
            UI._instance.Score += Score(gameObject);
            Destroy(gameObject, 0.8f);
        }
        else if (collider.tag == "Tank")
        {
            Instantiate(damage,gameObject.transform.position,gameObject.transform.rotation);
            Player._instance.HaemalStrand();
            Destroy(gameObject);
        }
    }

    int Score(GameObject obj)
    {
        if (obj.tag == "Cactus2")
        {
            return 2;
        }
        else if (obj.tag == "Cactus")
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
