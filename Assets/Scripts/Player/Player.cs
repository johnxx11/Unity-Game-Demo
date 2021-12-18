using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player _instance;

    public int timeVal = 3;
    public GameObject bullectPrefab;

    public AudioSource Soude;
    public AudioClip Fire;
    public AudioClip Reload;

    public GameObject Heart;
    public Image Over;
    public float move;
    void Awake()
    {
        _instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeVal == 0)
        {
            Load();
        }
        else if(timeVal == 3)
        {
            Attack();
        }
        else
        {
            Attack();
            Load();
        }

        GameManager();
    }

    private void FixedUpdate()
    {
        Turn();
    }

    void Turn()
    {
        move = Input.GetAxis("Horizontal");
        gameObject.transform.Rotate(0.0f , move * 80f * Time.deltaTime, 0.0f);
        
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space) && timeVal != 0)
        {
            Soude.clip = Fire;
            Soude.Play();
            Instantiate(bullectPrefab, transform.position + new Vector3(0, -0.2f, 0), Quaternion.Euler(transform.eulerAngles));
            timeVal--;
        }
    }

    void Load()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Soude.clip = Reload;
            Soude.Play();
            Invoke("Reloading", 1.5f);
        }
    }
    void Reloading()
    {
        timeVal = 3;
    }

    public void HaemalStrand()
    {
        Heart.GetComponent<Slider>().value += 0.2f;
    }

    public void GameManager()
    {
        if (Heart.GetComponent<Slider>().value >= 0.9f)
        {
            Time.timeScale = 0;
            Over.gameObject.SetActive(true);
        }
    }
}
