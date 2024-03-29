using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using System.Linq;



public class patientfiles : MonoBehaviour
{
    
    public GameObject patientlist;
    public GameObject basepatient;
    public TMP_InputField filename;
    
    public int x = 0;
    public int y = 0;
    public GameObject[] patient;
    // Start is called before the first frame update
    public void newpatient()
    { 
        if (filename.text != "")
        {
            
            Directory.CreateDirectory(Application.dataPath + "/patients" + ("/"+filename.text));
            x++;
            PlayerPrefs.SetInt("patientnumber", x);
            (Instantiate(basepatient) as GameObject).transform.SetParent(patientlist.transform);
            Array.Resize(ref patient, x);
            patient[x-1] = patientlist.transform.GetChild(x - 1).gameObject;
            patient[x-1].transform.localScale = new Vector3(1, 1, 1);
            patient[x-1].name = filename.text;
            TMP_Text name = patient[x - 1].transform.GetChild(1).GetComponent<TMP_Text>();
            name.text = filename.text;
            File.WriteAllText(Application.dataPath + "/patients" + "/"+(x-1).ToString() + ".text" ,filename.text);
            File.WriteAllText(Application.dataPath + "/currentpatient.text", filename.text);

        }
        else
        {
            Debug.LogError("insert patient name!!!!!");
        }
    }
    
    // Update is called once per frame
    void Start()
    {
        
        x = PlayerPrefs.GetInt("patientnumber");
        
        y = 0;
        Array.Resize(ref patient, x);
        if (!Directory.Exists("/patients"))
        {
            Directory.CreateDirectory(Application.dataPath + "/patients");
        }
       
        while (y<x)
        {   
            (Instantiate(basepatient) as GameObject).transform.SetParent(patientlist.transform);
            
            patient[y] = patientlist.transform.GetChild(y).gameObject;
            patient[y].transform.localScale = new Vector3(1, 1, 1);
            patient[y].name = File.ReadAllText(Application.dataPath + "/patients" + "/"+ y.ToString()+".text") ;
            TMP_Text name = patient[y].transform.GetChild(1).GetComponent<TMP_Text>();
            name.text = patient[y].name;
            y++;
        }
        y = 0;
    }
}
