using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    public Text timeText;
    float alive = 0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        timeText.text = alive.ToString("N2");
    }

    void makeSquare() 
    {
        Instantiate(square);
    }
}
