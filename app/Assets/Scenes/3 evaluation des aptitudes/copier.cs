using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class copier : MonoBehaviour
{
    public pressing option;

    public Image one;
    public Image two;
    public Image three;
    public Image four;
    public Image five;

    public bool oned;
    public bool twod;
    public bool threed;
    public bool fourd;
    public bool fived;
    void Start()
    {

    }

    public void press1()
    {
        one.color = new Color(1f, 0f, 0f, 1f);
        two.color = new Color(1f, 1f, 1f, 0f);
        three.color = new Color(1f, 1f, 1f, 0f);
        four.color = new Color(1f, 1f, 1f, 0f);
        five.color = new Color(1f, 1f, 1f, 0f);
        
    }
    public void press2()
    {
        one.color = new Color(1f, 0f, 0f, 1f);
        two.color = new Color(1f, 0.4f, 0f, 1f);
        three.color = new Color(1f, 0f, 0f, 0f);
        four.color = new Color(1f, 0f, 0f, 0f);
        five.color = new Color(1f, 0f, 0f, 0f);
        
    }
    public void press3()
    {
        one.color = new Color(1f, 0f, 0f, 1f);
        two.color = new Color(1f, 0.4f, 0f, 1f);
        three.color = new Color(1f, 0.65f, 0f, 1f);
        four.color = new Color(1f, 0f, 0f, 0f);
        five.color = new Color(1f, 0f, 0f, 0f);
       
    }
    public void press4()
    {
        one.color = new Color(1f, 0f, 0f, 1f);
        two.color = new Color(1f, 0.4f, 0f, 1f);
        three.color = new Color(1f, 0.65f, 0f, 1f);
        four.color = new Color(0.7f, 0.8f, 0f, 1f);
        five.color = new Color(1f, 0f, 0f, 0f);
        
    }
    public void press5()
    {
        one.color = new Color(1f, 0f, 0f, 1f);
        two.color = new Color(1f, 0.4f, 0f, 1f);
        three.color = new Color(1f, 0.65f, 0f, 1f);
        four.color = new Color(0.7f, 0.8f, 0f, 1f);
        five.color = new Color(0f, 1f, 0f, 1f);
        
    }

    public void clear()
    {
        one.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        two.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        three.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        four.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        five.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        
    }
    void Update()
    {
        oned = option.oned;
        twod = option.twod;
        threed = option.threed;
        fourd = option.fourd;
        fived = option.fived;
        if (oned && !twod && !threed && !fourd && !fived)
        {
            press1();
        }
        if (oned && twod && !threed && !fourd && !fived)
        {
            press2();
        }
        if (oned && twod && threed && !fourd && !fived)
        {
            press3();
        }
        if (oned && twod && threed && fourd && !fived)
        {
            press4();
        }
        if (oned && twod && threed && fourd && fived)
        {
            press5();
        }
        if (!oned && !twod && !threed && !fourd && !fived)
        {
            clear();
        }
    }
}