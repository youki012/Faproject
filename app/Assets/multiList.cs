using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class multiList : MonoBehaviour
{
    public RectTransform arrow;

    public GameObject butts;
    public GameObject butts2;
    public GameObject butts3;

    public bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void showdis()
    {
        if (active)
        {
            butts.SetActive(false);
            butts2.SetActive(false);
            butts3.SetActive(false);

            active = false;
            arrow.rotation = Quaternion.Euler(0f, 0f, 90f);
        }
        else
        {
            butts.SetActive(true);
            butts2.SetActive(true);
            butts3.SetActive(true);

            active = true;
            arrow.rotation = Quaternion.Euler(0f, 0f, 0f); 
        }
                
    }
    
    public void hidedis1()
    {
        active = true;
        showdis();
    }
    public void hidedis2()
    {
        active = true;
        showdis();
    }

}
