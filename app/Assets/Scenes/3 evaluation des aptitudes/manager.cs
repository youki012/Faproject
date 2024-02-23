using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public Image swscene3;
    public GameObject scene3;
    public Image swnewshi;
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
        swscene3.color = new Color(2f, 2f, 2f);
        swnewshi.color = new Color(0f, 0f, 0f);
    }
    public void switcher2()
    {
        scene3.SetActive(true);
        newshi.SetActive(false);
        swscene3.color = new Color(0f, 0f, 0f);
        swnewshi.color = new Color(2f, 2f, 2f);
    }
}
