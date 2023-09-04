using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class graphs : MonoBehaviour
{
    public RectTransform line;
    public float x = -0.6696296f;
    public float y = 0f;
    public void graphed()
    { 
        
        line.position = new Vector3(3.9f, x,90f);
        x += 0.5f;
        line.sizeDelta = new Vector2(100f, y);
        y += 108f;
    }
}
