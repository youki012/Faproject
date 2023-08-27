using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class pressing : MonoBehaviour
{

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

    public void press1()
    {
        one.color = new Color(0f,1f,0f,1f);
        two.color = new Color(1f, 0f, 0f, 1f);
        three.color = new Color(1f, 0f, 0f, 1f);
        four.color = new Color(1f, 0f, 0f, 1f);
        five.color = new Color(1f, 0f, 0f, 1f);
        oned = true; twod = false; threed = false; fourd = false; fived = false;
    }
    public void press2()
    {
        one.color = new Color(0f, 1f, 0f, 1f);
        two.color = new Color(0f, 1f, 0f, 1f);
        three.color = new Color(1f, 0f, 0f, 1f);
        four.color = new Color(1f, 0f, 0f, 1f);
        five.color = new Color(1f, 0f, 0f, 1f);
        oned = true; twod = true; threed = false; fourd = false; fived = false;
    }
    public void press3()
    {
        one.color = new Color(0f, 1f, 0f, 1f);
        two.color = new Color(0f, 1f, 0f, 1f);
        three.color = new Color(0f, 1f, 0f, 1f);
        four.color = new Color(1f, 0f, 0f, 1f);
        five.color = new Color(1f, 0f, 0f, 1f);
        oned = true; twod = true; threed = true; fourd = false; fived = false;
    }
    public void press4()
    {
        one.color = new Color(0f, 1f, 0f, 1f);
        two.color = new Color(0f, 1f, 0f, 1f);
        three.color = new Color(0f, 1f, 0f, 1f);
        four.color = new Color(0f, 1f, 0f, 1f);
        five.color = new Color(1f, 0f, 0f, 1f);
        oned = true; twod = true; threed = true; fourd = true; fived = false;
    }
    public void press5()
    {
        one.color = new Color(0f, 1f, 0f, 1f);
        two.color = new Color(0f, 1f, 0f, 1f);
        three.color = new Color(0f, 1f, 0f, 1f);
        four.color = new Color(0f, 1f, 0f, 1f);
        five.color = new Color(0f, 1f, 0f, 1f);
        oned = true; twod = true; threed = true; fourd = true; fived = true;
    }

    public void clear()
    {
        one.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        two.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        three.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        four.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        five.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        oned = false; twod = false; threed = false; fourd = false; fived = false;
    }
    public void update()
    {
        if (oned&&!twod&&!threed&&!fourd&&!fived)
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
