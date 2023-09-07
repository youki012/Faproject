using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class graphs : MonoBehaviour
{
    public RectTransform line;
    public float x = -0.6696296f;
    public float y = 0f;

    public int noflines;
    int timpo = 0;

    public linescore[] line1;
   
 
   

    public float total = 0f;
    public float totalcount = 0f;
    public float length;

  
    public void graphlength()
    {
        while (timpo < noflines)
        {
            total = total + line1[timpo].score;
            totalcount = totalcount + line1[timpo].count;
            timpo++;
        }
        length = total * 10f / (totalcount * 9f);
       
    }
    
    public void graphed()
    {
        x = 27f * length ;
        line.anchoredPosition = new Vector3(0f, x, 0f);
        
        y = 54f * length;
        line.sizeDelta = new Vector2(100f, y);
        
    }
}
