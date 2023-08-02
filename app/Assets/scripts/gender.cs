using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gender : MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle females;
    public Toggle males;
    bool f = false;
    bool m = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (females.isOn == true && males.isOn == true && m) { females.isOn = true; males.isOn = false; f = true; m = false; }
        if (females.isOn == true && males.isOn == true && f) { females.isOn = false; males.isOn = true; m = true; f = false; }

    }
}
