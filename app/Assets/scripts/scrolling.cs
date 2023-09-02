using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class scrolling : MonoBehaviour
{
    // Start is called before the first frame update
    public Scrollbar scrollbar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            uped();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downed();
        }
    }
    public void uped()
    {
        scrollbar.value += 0.09f;
    }
    public void downed()
    {
        scrollbar.value -= 0.09f;
    }
}
