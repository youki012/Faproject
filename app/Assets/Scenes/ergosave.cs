using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class ergosave : MonoBehaviour
{
    public TMP_InputField ergoname;
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(Application.dataPath + "/ergoname.text"))
        {
            ergoname.text = File.ReadAllText(Application.dataPath + "/ergoname.text");
        }
    }

    // Update is called once per frame
    public void save()
    {
        File.WriteAllText(Application.dataPath + "/ergoname.text", ergoname.text);
    }
}
