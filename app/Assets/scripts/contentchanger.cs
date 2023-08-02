using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class contentchanger : MonoBehaviour
{
    
    
    public GameObject prefabholder;

    public GameObject[] prefabs;

    public int prefsnumber;

    public int previous;

    void Update()
    {
        prefsnumber = prefabholder.transform.childCount;

        prefabs = new GameObject[prefsnumber];

        for (int i = 0; i < prefsnumber; i++)
        {
            prefabs[i] = prefabholder.transform.GetChild(i).gameObject;
        }
        if (prefsnumber > 1)
        {
            
        }
    }
    public void adder(int chatnum)
    {
        prefabs[previous].SetActive(false);

        prefabs[chatnum].SetActive(true);

        previous = chatnum;


    }
    // Update is called once per frame
    
}
