using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void makeSquare() 
    {
        Instantiate(square);
    }
}
