using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using JetBrains.Annotations;

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

    int y = 0;
    int x = 0;
    public void press1()
    {
        one.color = new Color(1f,0f,0f,1f);
        two.color = new Color(1f, 1f, 1f, 0f);
        three.color = new Color(1f, 1f, 1f, 0f);
        four.color = new Color(1f, 1f, 1f, 0f);
        five.color = new Color(1f, 1f, 1f, 0f);
        oned = true; twod = false; threed = false; fourd = false; fived = false;

        
    }
    public void press2()
    {
        one.color = new Color(1f, 0f, 0f, 1f);
        two.color = new Color(1f, 0.4f, 0f, 1f);
        three.color = new Color(1f, 0f, 0f, 0f);
        four.color = new Color(1f, 0f, 0f, 0f);
        five.color = new Color(1f, 0f, 0f, 0f);
        oned = true; twod = true; threed = false; fourd = false; fived = false;
    }
    public void press3()
    {
        one.color = new Color(1f, 0f, 0f, 1f);
        two.color = new Color(1f, 0.4f, 0f, 1f);
        three.color = new Color(1f, 0.65f, 0f, 1f);
        four.color = new Color(1f, 0f, 0f, 0f);
        five.color = new Color(1f, 0f, 0f, 0f);
        oned = true; twod = true; threed = true; fourd = false; fived = false;
    }
    public void press4()
    {
        one.color = new Color(1f, 0f, 0f, 1f);
        two.color = new Color(1f, 0.4f, 0f, 1f);
        three.color = new Color(1f, 0.65f, 0f, 1f);
        four.color = new Color(0.7f, 0.8f, 0f, 1f);
        five.color = new Color(1f, 0f, 0f, 0f);
        oned = true; twod = true; threed = true; fourd = true; fived = false;
    }
    public void press5()
    {
        one.color = new Color(1f, 0f, 0f, 1f);
        two.color = new Color(1f, 0.4f, 0f, 1f);
        three.color = new Color(1f, 0.65f, 0f, 1f);
        four.color = new Color(0.7f, 0.8f, 0f, 1f);
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
    public void Update()
    {
        if (PlayerPrefs.GetInt("savable3") == 1)
        {
            
            if (File.Exists(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name)) {

                if (File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name) == "1")
                {
                    press1();
                }
                else if (File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name) == "2")
                {
                    press2();
                }
                else
                if (File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name) == "3")
                {
                    press3();
                }
                else
                if (File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name) == "4")
                {
                    press4();
                }
                else
                if (File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name) == "5")
                {
                    press5();
                }
                else
                if (File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name) == "0")
                {
                    clear();
                }
            }
            y++;
            if (y > 2)
            {
                PlayerPrefs.SetInt("savable3", 0);
                y = 0;
            }

        }
        
        if (PlayerPrefs.GetInt("savable30") == 1)
        {
            
            if (oned && !twod && !threed && !fourd && !fived)
            {
                press1();
                File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name, "1");
            }
            if (oned && twod && !threed && !fourd && !fived)
            {
                press2();
                File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name, "2");

            }
            if (oned && twod && threed && !fourd && !fived)
            {
                press3();
                File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name, "3");
            }
            if (oned && twod && threed && fourd && !fived)
            {
                press4();
                File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name, "4");
            }
            if (oned && twod && threed && fourd && fived)
            {
                press5();
                File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name, "5");
            }
            if (!oned && !twod && !threed && !fourd && !fived)
            {
                clear();
                File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation" + "/" + gameObject.name, "0");
            }
            x++;
            if (x > 2)
            {
                PlayerPrefs.SetInt("savable30", 0);
                x = 0;
            }
        }
        
    }
  
}
