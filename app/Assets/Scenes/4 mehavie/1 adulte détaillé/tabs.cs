using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tabs : MonoBehaviour
{
    public GameObject nutrition1;
    public GameObject Soinspersonels2;
        public GameObject Habitation3;
        public GameObject Responsabilités4;
        public GameObject Viecommunantaire5;
        public GameObject Travail6;
        public GameObject Conditionscorporelle7;
        public GameObject Communication8;
        public GameObject Déplacement9;       
        public GameObject Education11;
        public GameObject Loisirs12;

    public GameObject graphs;

    int x = 0;
    // Update is called once per frame
    void Start()
    {

        nutrition1.SetActive(true);
        Soinspersonels2.SetActive(true);
        Habitation3.SetActive(true);
        Responsabilités4.SetActive(true);
        Viecommunantaire5.SetActive(true);
        Travail6.SetActive(true);
        Conditionscorporelle7.SetActive(true);
        Communication8.SetActive(true);
        Déplacement9.SetActive(true);

        Education11.SetActive(true);
        Loisirs12.SetActive(true);
        graphs.SetActive(false);
        x = 0;

    }
    private void Update()
    {
        if (x < 100)
        {
            x++;
        }
        if (x > 50&&x<75)
        {
            nutrition();
        }
       
    }
    public void nutrition()
    {
        nutrition1.SetActive(true);
        Soinspersonels2.SetActive(false);
        Habitation3.SetActive(false);
        Responsabilités4.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Travail6.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Communication8.SetActive(false);
        Déplacement9.SetActive(false);
       
        Education11.SetActive(false);
        Loisirs12.SetActive(false);
        graphs.SetActive(false);
    }
public void Soinspersonels()
    {
        Soinspersonels2.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
    nutrition1.SetActive(false);
        graphs.SetActive(false);
    }
public void Habitation()
    {
        Habitation3.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
        graphs.SetActive(false);
    }
public void Responsabilités()
    {
        Responsabilités4.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
       
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
        graphs.SetActive(false);
    }
public void Viecommunantaire()
    {
        Viecommunantaire5.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
        graphs.SetActive(false);
    }
public void Travail()
    {
        Travail6.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
       
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
        graphs.SetActive(false);
    }
public void Conditionscorporelle()
    {
        Conditionscorporelle7.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
        graphs.SetActive(false);
    }
public void Communication()
    {
        Communication8.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        
        Déplacement9.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
        graphs.SetActive(false);
    }
public void Déplacement()
    {
        Déplacement9.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
        graphs.SetActive(false);
    }

public void Education()
    {
        Education11.SetActive(true);
        Loisirs12.SetActive(false);
        
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
        graphs.SetActive(false);
    }
public void Loisirs()
    {
        Loisirs12.SetActive(true);
        Education11.SetActive(false);
        
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
        graphs.SetActive(false);
    }
    public void graphing()
    {
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
        nutrition1.SetActive(false);
        graphs.SetActive(true);
    }
}
