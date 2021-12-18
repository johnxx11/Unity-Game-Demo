using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static UI _instance;

    public Image Bullabte1;
    public Image Bullabte2;
    public Image Bullabte3;
    public int BullabteNumber;
    public int Score;
    public Text ScoreUI;

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
        BullabteImage();
        BullabteNumber = Player._instance.timeVal;

        ScoreUI.text = Score.ToString();
    }

    void BullabteImage()
    {
        if (BullabteNumber == 3)
        {
            Bullabte1.gameObject.SetActive(true);
            Bullabte2.gameObject.SetActive(true);
            Bullabte3.gameObject.SetActive(true);
        }
        else if (BullabteNumber == 2)
        {
            Bullabte1.gameObject.SetActive(false);
            Bullabte2.gameObject.SetActive(true);
            Bullabte3.gameObject.SetActive(true);
        }
        else if (BullabteNumber == 1)
        {
            Bullabte1.gameObject.SetActive(false);
            Bullabte2.gameObject.SetActive(false);
            Bullabte3.gameObject.SetActive(true);
        }
        else if (BullabteNumber == 0)
        {
            Bullabte1.gameObject.SetActive(false);
            Bullabte2.gameObject.SetActive(false);
            Bullabte3.gameObject.SetActive(false);
        }
    }
}
