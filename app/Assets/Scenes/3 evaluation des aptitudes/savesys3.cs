using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using TMPro;
using UnityEngine;

public class savesys3 : MonoBehaviour
{

    public int x;
    public int y;
  
    void Start()
    {
        load();
    }

    // Update is called once per frame
    public void load()
    {
        PlayerPrefs.SetInt("savable3", 1);
    }
    private void Update()
    {
        x = PlayerPrefs.GetInt("savable3");
        y = PlayerPrefs.GetInt("savable30");
       
        
    }
    public void save()
    {
        PlayerPrefs.SetInt("savable30", 1);
    }
}
