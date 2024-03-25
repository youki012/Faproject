using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class datedisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField date;

    // Update is called once per frame
    public void Updatedate()
    {
        string day = System.DateTime.UtcNow.ToLocalTime().ToString("dd");
        
        string month = System.DateTime.UtcNow.ToLocalTime().ToString("MM");
       
        string year = System.DateTime.UtcNow.ToLocalTime().ToString("yyyy");

        date.text = day + "/" + month + "/" + year;
    }
}
