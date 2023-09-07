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

    public linescore line1;
    public linescore line2;
    public linescore line3;
    public linescore line4;

    public float total;
    public float length;

    public void graphed()
    { 
        
        line.position = new Vector3(3.9f, x,90f);
        x += 0.25f;
        line.sizeDelta = new Vector2(100f, y);
        y += 54f;
    }
    public void graphlength()
    {
        total = line1.count + line2.count ;

        length = (line1.score + line2.score ) * 10f / total;
    }
    private void Update()
    {
        graphlength();
    }
}
