using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class CanvasCode : MonoBehaviour
{
    public TextMeshProUGUI Counter;
    int counter = 3;
   
    void Start()
    {
        Count();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Count()
    {
        
        Counter.text = counter.ToString();
        counter--;
        if (counter > -1)
        {
            Invoke("Count", 1);
        }
        else
        {
            Counter.text = null;
        }

    }
}
