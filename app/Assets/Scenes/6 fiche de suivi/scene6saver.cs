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
        Load();
    }
    public void Save()
    {
        
        Directory.CreateDirectory(Application.dataPath + "/infopage");


        File.WriteAllText(Application.streamingAssetsPath + "dates.text", dates.text);   
        File.WriteAllText(Application.streamingAssetsPath + "modeinterv.text", modeinterv.text);  
        File.WriteAllText(Application.streamingAssetsPath + "observations.text", observations.text);  
      
       

       
        Debug.Log("saved!");
    }


    public void Load()
    {
        

        dates.text = File.ReadAllText(Application.streamingAssetsPath + "dates.text");  
        modeinterv.text = File.ReadAllText(Application.streamingAssetsPath + "modeinterv.text"); 
        observations.text = File.ReadAllText(Application.streamingAssetsPath + "observations.text"); 
     

       

        Debug.Log("loaded!");
    }

}
