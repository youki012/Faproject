using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class extrasave4 : MonoBehaviour
{

   
    public GameObject circlesholder;
    int x = 0;
    public string selectedmeavie;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "détaillé")
        {
            selectedmeavie = "/mhavieDetail";
        }
        else
        {
            selectedmeavie = "/mhavieAbrege";
        }


        if (File.Exists(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.name + gameObject.transform.GetChild(x).name + ".text"))
        {
       
                while (x < circlesholder.transform.childCount)
            {

                circlesholder.transform.GetChild(x).transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Toggle>().isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.name + gameObject.transform.GetChild(x).name + ".text"));
                x++;
            }
            x = 0;
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            while (x < circlesholder.transform.childCount)
            {
                
                    File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/mhavie" + selectedmeavie + "/" + gameObject.transform.name + gameObject.transform.GetChild(x).name + ".text", circlesholder.transform.GetChild(x).transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Toggle>().isOn.ToString());
                x++;
            }
            x = 0;
        }
    }
}
