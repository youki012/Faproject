using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class adder : MonoBehaviour 
{
    public float x;

    public float y;
    // Start is called before the first frame update

   
    // Update is called once per frame
    void Update()
    {
        y = x;
        y =  (int)(y*100) ;

        x = y / 100;
    }
   
}
