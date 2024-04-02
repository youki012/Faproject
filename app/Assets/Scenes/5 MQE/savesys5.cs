using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class savesys5 : MonoBehaviour
{
    public GameObject checksholder;
    public GameObject[] checks = new GameObject[67];
    int x = 0;
    int y = 0;
    void Start()
    {
        while (x < 67)
        {
            checks[x] = checksholder.transform.GetChild(x).gameObject;
            x++;
        }
        x = 0;
        load();
    }

    // Update is called once per frame
    public void save()
    {
        while (x < 67)
        {
            while (y < 9)
            {
                bool selected = checks[x].transform.GetChild(y).gameObject.GetComponent<Toggle>().isOn;
                File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/MQE" + "/"+x.ToString() + y.ToString()+".text", selected.ToString());
                y++;
            }
            y = 0;
            x++;
        }
        x = 0;
        y = 0;
    }
    public void load()
    {
        while (x < 67)
        {
            while (y < 9)
            {
                checks[x].transform.GetChild(y).gameObject.GetComponent<Toggle>().isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/MQE" + "/" + x.ToString() + y.ToString() + ".text"));
                y++;
            }
            y = 0;
            x++;
        }
        x = 0;
        y = 0;
    }
}
