using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;
using System.Linq;
using System;


public class scene1saver : MonoBehaviour
{
    
    public TMP_InputField nom;
    
    
    
    public void Save()
    {

        Directory.CreateDirectory(Application.dataPath + "/infopage");
        File.WriteAllText(Application.dataPath + "/infopage" + "name.text", nom.text);       
                          
        Debug.Log("saved!");
    }


    public void Load()
    {
        nom.text = File.ReadAllText(Application.dataPath + "/infopage" + "name.text");        
        
        Debug.Log("loaded!");
    }

}
