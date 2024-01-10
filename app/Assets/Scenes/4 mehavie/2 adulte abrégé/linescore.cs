using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class linescore : MonoBehaviour
{
    // Start is called before the first frame update
    public float score = 0f;
    public float count = 0f;
    public bool A;
    public bool B;
    public bool C;
    public bool D;
    public bool E;
    public bool F;
    public bool G;
    public bool H;
    public bool I;

    public Toggle AA;
    public Toggle BB;
    public Toggle CC;
    public Toggle DD;
    public Toggle EE;
    public Toggle FF;
    public Toggle GG;
    public Toggle HH;
    public Toggle II;
   

    public void calculategraph()
    {
        A = AA.isOn;
        B = BB.isOn;
        C = CC.isOn;
        D = DD.isOn;
        E = EE.isOn;
        F = FF.isOn;
        G = GG.isOn;
        H = HH.isOn;
        I= II.isOn;

        if (A&&!B&&!C&&!D&&!E&&!F&&!G&&!H&&!I)
        {
            score = 9;
            count = 1;
        }
        else if (A && (G || H) && !B && !C && !D && !E && !F && !I)
        {
            score = 8;
            count = 1;
        }
        else if (B && F && !A && !C && !D && !E && !G && !H && !I)
        {
            score = 7;
            count = 1;
        }
        else if (B && (G || H) && !A && !C && !D && !E && !F && !I)
        {
            score = 6;
            count = 1;
        }
        else if (A && I && !B && !C && !D && !E && !F && !G && !H )
        {
            score = 5;
        }
        else if (A && I && (G || H) && !B && !C && !D && !E && !F )
        {
            score = 4;
            count = 1;
        }
        else if (B && I && !A && !C && !D && !E && !F && !G && !H )
        {
            score = 3;
            count = 1;
        }
        else if (B && I && (G || H) && !A && !C && !D && !E && !F )
        {
            score = 2;
            count = 1;
        }
        else if (C && !B && !A && !D && !E && !F && !G && !H && !I)
        {
            score = 1;
            count = 1;
        }
        else if (D && !B && !C && !A && !E && !F && !G && !H && !I)
        {
            score = 0;
            count = 1;
        }
        else
        {
            score = 0;
            count = 0;
        }



    }
    private void Start()
    {
        calculategraph();
    }
}
