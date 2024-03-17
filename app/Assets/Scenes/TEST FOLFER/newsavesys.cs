using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;
using System.Linq;
using System;

public class newsavesys : MonoBehaviour
{
    public string[] all;
    public TMP_InputField text;
    public string savedshit;
    public string filename;
    public int x;
    public void Save()
    {
        
        savedshit = text.text;
        File.WriteAllText(Application.dataPath + "/save.text", savedshit);
        Debug.Log("saved!");



        Directory.CreateDirectory(Application.dataPath + filename);
        x = 0;
        File.WriteAllText(Application.dataPath + filename +"/listlength.text", all.Length.ToString());
        File.WriteAllText(Application.dataPath + "/filename.text", filename);
        while (all.Length > x)
        {
            File.WriteAllText(Application.dataPath + filename + "/"+ x.ToString() + ".text", all[x]);
            x++;
        }
        
    }

    
    public void Load()
    {
        
        text.text = File.ReadAllText(Application.dataPath + "/save.text");


        x = 0;
        filename = File.ReadAllText(Application.dataPath + "/filename.text");
        Array.Resize(ref all, int.Parse(File.ReadAllText(Application.dataPath + filename + "/listlength.text")));
        Debug.Log("loaded!");
        while (all.Length > x)
        {
            all[x] = File.ReadAllText(Application.dataPath + filename + "/" + x.ToString() + ".text");
            x++;
        }
    }
}
