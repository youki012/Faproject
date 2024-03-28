using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class currentpatient : MonoBehaviour
{
    // Start is called before the first frame update
    public void patientpress()
    {
        File.WriteAllText(Application.dataPath + "/currentpatient.text", gameObject.name);
    }

}
