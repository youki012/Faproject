using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;
using System.Linq;
using System;

public class scene6saver : MonoBehaviour
{   

    public TMP_InputField dates;   
    public TMP_InputField modeinterv;   
    public TMP_InputField observations;

    private void Start()
    {
        if (File.Exists(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/FichesDeSuivi" + "/dates.text"))
        {
            Load();
        }
    }
    public void Save()
    {
        
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/FichesDeSuivi" + "/dates.text", dates.text);   
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/FichesDeSuivi" + "/modeinterv.text", modeinterv.text);  
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/FichesDeSuivi" + "/observations.text", observations.text);  
      
       

       
        Debug.Log("saved!");
    }


    public void Load()
    {
        

        dates.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/FichesDeSuivi" + "/dates.text");  
        modeinterv.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/FichesDeSuivi" + "/modeinterv.text"); 
        observations.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/FichesDeSuivi" + "/observations.text"); 
     

       

        Debug.Log("loaded!");
    }

}
