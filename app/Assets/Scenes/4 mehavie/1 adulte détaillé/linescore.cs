using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;

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

    public Toggle JJ;
    public Toggle KK;
    public Toggle LL;
    public Toggle MM;
    public Toggle NN;

    public string selectedmeavie;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "détaillé")
        {
            selectedmeavie = "/mhavieDetail";
        }
        else
        {
            selectedmeavie = "/mhavieAbrege";
        }
        calculategraph();
        if (File.Exists(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "0" + ".text")){
            load();
        }
    }
    public void save()
    {
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/"+ gameObject.transform.parent.name + gameObject.name+ "0" + ".text", AA.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "1"+ ".text", BB.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "2" + ".text", CC.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "3" + ".text", DD.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "4" + ".text", EE.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "5" + ".text", FF.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "6" + ".text", GG.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "7" + ".text", HH.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "8" + ".text", II.isOn.ToString());

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "9" + ".text", JJ.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "10" + ".text", KK.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "11" + ".text", LL.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "12" + ".text", MM.isOn.ToString());
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "13" + ".text", NN.isOn.ToString());

    }

    public void load()
    {
        AA.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "0" + ".text"));
        BB.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "1" + ".text"));
        CC.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "2" + ".text"));
        DD.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "3" + ".text"));
        EE.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "4" + ".text"));
        FF.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "5" + ".text"));
        GG.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "6" + ".text"));
        HH.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "7" + ".text"));
        II.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "8" + ".text"));

        JJ.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "9" + ".text"));
        KK.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "10" + ".text"));
        LL.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "11" + ".text"));
        MM.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "12" + ".text"));
        NN.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.parent.name + gameObject.name + "13" + ".text"));
    }


    public void Update()
    {
        if (Input.GetMouseButtonDown(0)||Input.GetMouseButtonDown(1))
        {
            save();
        }
    }
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
  
}
