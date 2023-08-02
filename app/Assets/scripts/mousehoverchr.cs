using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousehoverchr : MonoBehaviour
{
    public GameObject name;
    void OnMouseOver()
    {
        name.SetActive(true);
    }
    void OnMouseExit()
    {
        name.SetActive(false);
    }
}
