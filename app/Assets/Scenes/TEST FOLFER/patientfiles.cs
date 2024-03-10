using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class patientfiles : MonoBehaviour
{
    public string filename;
    // Start is called before the first frame update
    public void save()
    { 
        if (filename != "")
        {
            Directory.CreateDirectory(Application.streamingAssetsPath + ("/"+filename));
            
        }
        else
        {
            Debug.LogError("insert patient name!!!!!");
        }
    }
    
    // Update is called once per frame
    void Update()
    {
       
    }
}
