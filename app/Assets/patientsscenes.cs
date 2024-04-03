using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;
using System.Linq;
using System;
public class patientsscenes : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text patientname;
    void Start()
    {
        if(!File.Exists("/"+File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral"))
        {
            Directory.CreateDirectory(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" );
            Directory.CreateDirectory(Application.dataPath +  "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance");
            Directory.CreateDirectory(Application.dataPath +  "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/AptitudesEtCorrelation");
            Directory.CreateDirectory(Application.dataPath +  "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie");
            Directory.CreateDirectory(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + "/mhavieDetail");
            Directory.CreateDirectory(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + "/mhavieAbrege");
            Directory.CreateDirectory(Application.dataPath +  "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/MQE");
            Directory.CreateDirectory(Application.dataPath +  "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/FichesDeSuivi");
        }
        patientname.text = File.ReadAllText(Application.dataPath + "/currentpatient.text");
    }


}
