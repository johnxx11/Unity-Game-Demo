using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthEnemy : MonoBehaviour
{
    float CreatTime = 5f;
    GameObject Enemy;

    public GameObject Enemyobj;
    public GameObject Enemyobj2;

    public GameObject BirthPos1;
    public GameObject BirthPos2;
    public GameObject BirthPos3;
    public GameObject BirthPos4;

    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame



    void Update()
    {
        CreatTime -= Time.deltaTime;    // count down
        if (CreatTime <= 0)    
        {
            CreatTime = Random.Range(3, 10);     // random 3-9 seconds

            if (CreatTime == 9)
            {
                Enemy = Instantiate(Enemyobj2);    // instantiate Enemy
            }
            else
            {
                Enemy = Instantiate(Enemyobj);    
            }

            int i = Random.Range(1, 5);
            if (i == 1)
            {
                Enemy.transform.position = BirthPos1.transform.localPosition;
            }
            else if(i == 2)
            {
                Enemy.transform.position = BirthPos2.transform.localPosition;
            }
            else if (i == 3)
            {
                Enemy.transform.position = BirthPos3.transform.localPosition;
            }
            else if (i == 4)
            {
                Enemy.transform.position = BirthPos4.transform.localPosition;
            }
        }
    }
}
