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
    public gender gender;
    
    
    public void Save()
    {
        
        Directory.CreateDirectory(Application.dataPath + "/infopage");
        File.WriteAllText(Application.dataPath + "name.text", nom.text);
        File.WriteAllText(Application.dataPath  + "gender.text", gender.f.ToString());

        Debug.Log("saved!");
    }


    public void Load()
    {
        nom.text = File.ReadAllText(Application.dataPath + "name.text");
        gender.females.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "gender.text"));
        gender.males.isOn = !bool.Parse(File.ReadAllText(Application.dataPath + "gender.text"));

        Debug.Log("loaded!");
    }

}
