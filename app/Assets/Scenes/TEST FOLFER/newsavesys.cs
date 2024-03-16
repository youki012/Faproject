using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class newsavesys : MonoBehaviour
{
    public string[] all;
    public TMP_InputField text;
    public string savedshit;
    // Start is called before the first frame update
    public int x;
    public void Save()
    {
        x = 0;
        savedshit = text.text;
        File.WriteAllText(Application.dataPath + "/save.text", savedshit);
        Debug.Log("saved!");
        while(all.Length > x)
        {
            File.WriteAllText(Application.dataPath + "/save.text" + x.ToString(), all[x]);
            x++;
        }
        
    }

    // Update is called once per frame
    public void Load()
    {
        text.text = File.ReadAllText(Application.dataPath + "/save.text");
        Debug.Log("loaded!");
    }
}
