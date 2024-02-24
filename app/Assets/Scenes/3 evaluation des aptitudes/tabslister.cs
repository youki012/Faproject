using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class tabslister : MonoBehaviour
{

    public GameObject[] Element;
    public int totalElements;
    public GameObject ContentHolder;

    public GameObject[] butts;
    

    
    int x = 0;
    public int numofbuts;
 
    void Start()
    {
        totalElements = ContentHolder.transform.childCount;

        Element = new GameObject[totalElements];

        for (int i = 0; i < totalElements; i++)
        {
            Element[i] = ContentHolder.transform.GetChild(i).gameObject;
        }
    }


    public void showdis()
    {
       
            while (x < totalElements)
            {
                Element[x].SetActive(false);
                x++;
            }


            x = 0;
            
           
       
            while (x < numofbuts)
            {
                butts[x].SetActive(true);
                x++;
            }

            x = 0;
           
    }
}
