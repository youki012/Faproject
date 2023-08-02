using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class datedisplayer : MonoBehaviour
{
    public int dd;
    public int mm;
    public int yy;

    public int bdd ;
    public int bmm ;
    public int byy ;

    public int nd;
    public int nm;
    public int ny;

    public int age;

    public Text aged;
    // Start is called before the first frame update
    public TMP_Dropdown dropd;
    public TMP_Dropdown dropm;
    public TMP_Dropdown dropy;


    public void changed()
    {
        nd = dropd.value;
        nm = dropm.value;
        ny = dropy.value;
    }
    void FixedUpdate()
    {

        bdd = int.Parse(dropd.options[nd].text);
        bmm = int.Parse(dropm.options[nm].text);
        byy = int.Parse(dropy.options[ny].text);


        string day = System.DateTime.UtcNow.ToLocalTime().ToString("dd");       
        dd = int.Parse(day);
        string month = System.DateTime.UtcNow.ToLocalTime().ToString("MM");
        mm = int.Parse(month);
        string year = System.DateTime.UtcNow.ToLocalTime().ToString("yyyy");
        yy = int.Parse(year);

        age = yy - byy;
        if (mm < bmm) { age--; }
        else if (mm == bmm) { if (dd < bdd) { age--; } }

        aged.text = age.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
