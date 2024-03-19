using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class graphs : MonoBehaviour
{
    public RectTransform line;
    public RectTransform linedis;
    public TextMeshProUGUI linedistext;

    public float x = -0.6696296f;
    public float y = 0f;
    public float dis;
    public int noflines;
    int timpo = 0;

    public linescore[] line1;

    float z;
   

    public float total = 0f;
    public float totalcount = 0f;
    public float length;

  
    public void graphlength()
    {
        while (timpo < noflines)
        {
            line1[timpo].calculategraph();
            total = total + line1[timpo].score;
            totalcount = totalcount + line1[timpo].count;
            timpo++;
            
        }
        length = total * 10f / (totalcount * 9f);
        
        z = (int)(length * 100);
        length = z / 100;

        timpo = 0;
        total = 0f;
        totalcount = 0f;
        graphed();
    }
    
    public void graphed()
    {
        x = 27f * length ;
        dis = 54f * length;
        line.anchoredPosition = new Vector3(0f, x, 0f);
        linedis.anchoredPosition = new Vector3(0f,dis+10,0f);
        linedistext.text = length.ToString();
        
        y = 54f * length;
        line.sizeDelta = new Vector2(100f, y);
        
    }
}
