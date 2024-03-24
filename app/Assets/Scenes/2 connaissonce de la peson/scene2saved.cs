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
   

    public void Save()
    {
        
        Directory.CreateDirectory(Application.dataPath + "/infopage");


        File.WriteAllText(Application.streamingAssetsPath + "presentationclinique.text", presentationclinique.text);   
        File.WriteAllText(Application.streamingAssetsPath + "habitudesant.text", habitudesant.text);  
        File.WriteAllText(Application.streamingAssetsPath + "projetsdupatient.text", projetsdupatient.text);  
        File.WriteAllText(Application.streamingAssetsPath + "attentes.text", attentes.text);  
        File.WriteAllText(Application.streamingAssetsPath + "objectifscourt.text", objectifscourt.text);  
        File.WriteAllText(Application.streamingAssetsPath + "echeances.text", echeances.text);  
        File.WriteAllText(Application.streamingAssetsPath + "objectifslong.text", objectifslong.text);  
        File.WriteAllText(Application.streamingAssetsPath + "echeance.text", echeances.text);  

       

       
        Debug.Log("saved!");
    }


    public void Load()
    {
        

        presentationclinique.text = File.ReadAllText(Application.streamingAssetsPath + "presentationclinique.text");  
        habitudesant.text = File.ReadAllText(Application.streamingAssetsPath + "habitudesant.text"); 
        projetsdupatient.text = File.ReadAllText(Application.streamingAssetsPath + "projetsdupatient.text"); 
        attentes.text = File.ReadAllText(Application.streamingAssetsPath + "attentes.text"); 
        objectifscourt.text = File.ReadAllText(Application.streamingAssetsPath + "objectifscourt.text"); 
        echeances.text = File.ReadAllText(Application.streamingAssetsPath + "echeances.text"); 
        objectifslong.text = File.ReadAllText(Application.streamingAssetsPath + "objectifslong.text"); 
        echeance.text = File.ReadAllText(Application.streamingAssetsPath + "echeance.text");    

       

        Debug.Log("loaded!");
    }

}
