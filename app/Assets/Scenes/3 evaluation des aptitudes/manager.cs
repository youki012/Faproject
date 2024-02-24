using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public GameObject swscene3;
    public GameObject scene3;
    public GameObject swnewshi;
    public GameObject newshi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void switcher1()
    {       
        newshi.SetActive(true);
        scene3.SetActive(false);
        swscene3.SetActive(true);
        swnewshi.SetActive(false);
    }
    public void switcher2()
    {
        scene3.SetActive(true);
        newshi.SetActive(false);
        swscene3.SetActive(false);
        swnewshi.SetActive(true);
    }
}
