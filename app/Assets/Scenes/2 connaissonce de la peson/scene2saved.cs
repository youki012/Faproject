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

    public TMP_InputField présentation clinique du patient;   
    public TMP_InputField habitudes antérieures de vie;   
    public TMP_InputField projets du patient;   
    public TMP_InputField attentes de l'entourage;   
    public TMP_InputField objectifs à court terme;   
    public TMP_InputField echéances;   
    public TMP_InputField objectifs à long terme;   
    public TMP_InputField echéances;   
   

    public void Save()
    {
        
        Directory.CreateDirectory(Application.dataPath + "/infopage");


        File.WriteAllText(Application.streamingAssetsPath + "présentation clinique du patient.text", présentation clinique du patient.text);   
        File.WriteAllText(Application.streamingAssetsPath + "habitudes antérieures de vie.text", habitudes antérieures de vie.text);  
        File.WriteAllText(Application.streamingAssetsPath + "projets du patient.text", projets du patient.text);  
        File.WriteAllText(Application.streamingAssetsPath + "attentes de l'entourage.text", attentes de l'entourage.text);  
        File.WriteAllText(Application.streamingAssetsPath + "objectifs à court terme.text", objectifs à court terme.text);  
        File.WriteAllText(Application.streamingAssetsPath + "echéances.text", echéances.text);  
        File.WriteAllText(Application.streamingAssetsPath + "objectifs à long terme.text", objectifs à long terme.text);  
        File.WriteAllText(Application.streamingAssetsPath + "echéances.text", echéances.text);  

       

       
        Debug.Log("saved!");
    }


    public void Load()
    {
        

        présentation clinique du patient.text = File.ReadAllText(Application.streamingAssetsPath + "présentation clinique du patient.text");  
        habitudes antérieures de vie.text = File.ReadAllText(Application.streamingAssetsPath + "habitudes antérieures de vie.text"); 
        projets du patient.text = File.ReadAllText(Application.streamingAssetsPath + "projets du patient.text"); 
        attentes de l'entourage.text = File.ReadAllText(Application.streamingAssetsPath + "attentes de l'entourage.text"); 
        objectifs à court terme.text = File.ReadAllText(Application.streamingAssetsPath + "objectifs à court terme.text"); 
        echéances.text = File.ReadAllText(Application.streamingAssetsPath + "echéances.text"); 
        objectifs à long terme.text = File.ReadAllText(Application.streamingAssetsPath + "objectifs à long terme.text"); 
        echéances.text = File.ReadAllText(Application.streamingAssetsPath + "echéances.text");    

       

        Debug.Log("loaded!");
    }

}
