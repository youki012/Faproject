using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openmenu : MonoBehaviour
{
    bool clicked = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void appear(GameObject view)
    {
        if (clicked) 
        {
            view.SetActive(true);
            clicked = false;
        }
        else { view.SetActive(false);
            clicked = true;
        }
      
    }
}
