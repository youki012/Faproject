using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;
using System.Linq;
using System;

public class scene2saver : MonoBehaviour
{   

    public TMP_InputField presentationclinique;   
    public TMP_InputField habitudesant;   
    public TMP_InputField projetsdupatient;   
    public TMP_InputField attentes;   
    public TMP_InputField objectifscourt;   
    public TMP_InputField echeances;   
    public TMP_InputField objectifslong;   
    public TMP_InputField echeance;

    private void Start()
    {
        if (File.Exists(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/presentationclinique.text"))
        {
            Load();
        }
    }

    public void Save()
    {
        
       


        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/presentationclinique.text", presentationclinique.text);   
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/habitudesant.text", habitudesant.text);  
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/projetsdupatient.text", projetsdupatient.text);  
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/attentes.text", attentes.text);  
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/objectifscourt.text", objectifscourt.text);  
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/echeances.text", echeances.text);  
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/objectifslong.text", objectifslong.text);  
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/echeance.text", echeances.text);  

       

       
        Debug.Log("saved!");
    }


    public void Load()
    {
        

        presentationclinique.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/presentationclinique.text");  
        habitudesant.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/habitudesant.text"); 
        projetsdupatient.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/projetsdupatient.text"); 
        attentes.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/attentes.text"); 
        objectifscourt.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/objectifscourt.text"); 
        echeances.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/echeances.text"); 
        objectifslong.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/objectifslong.text"); 
        echeance.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/Connaissance" + "/echeance.text");    

       

        Debug.Log("loaded!");
    }

}
