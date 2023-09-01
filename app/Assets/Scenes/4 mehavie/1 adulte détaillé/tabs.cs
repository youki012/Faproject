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
        public GameObject Relationsinterpersonels10;
        public GameObject Education11;
        public GameObject Loisirs12;
    // Update is called once per frame
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
        Relationsinterpersonels10.SetActive(false);
        Education11.SetActive(false);
        Loisirs12.SetActive(false);
    }
public void Soinspersonels()
    {
        Soinspersonels2.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        Relationsinterpersonels10.SetActive(false);
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
    nutrition1.SetActive(false);
}
public void Habitation()
    {
        Habitation3.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        Relationsinterpersonels10.SetActive(false);
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
}
public void Responsabilités()
    {
        Responsabilités4.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        Relationsinterpersonels10.SetActive(false);
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
}
public void Viecommunantaire()
    {
        Viecommunantaire5.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        Relationsinterpersonels10.SetActive(false);
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
}
public void Travail()
    {
        Travail6.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        Relationsinterpersonels10.SetActive(false);
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
}
public void Conditionscorporelle()
    {
        Conditionscorporelle7.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        Relationsinterpersonels10.SetActive(false);
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
}
public void Communication()
    {
        Communication8.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        Relationsinterpersonels10.SetActive(false);
        Déplacement9.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
}
public void Déplacement()
    {
        Déplacement9.SetActive(true);
        Loisirs12.SetActive(false);
        Education11.SetActive(false);
        Relationsinterpersonels10.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
}
public void Relationsinterpersonels()
    {
        Relationsinterpersonels10.SetActive(true);
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
}
public void Education()
    {
        Education11.SetActive(true);
        Loisirs12.SetActive(false);
        Relationsinterpersonels10.SetActive(false);
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
}
public void Loisirs()
    {
        Loisirs12.SetActive(true);
        Education11.SetActive(false);
        Relationsinterpersonels10.SetActive(false);
        Déplacement9.SetActive(false);
        Communication8.SetActive(false);
        Conditionscorporelle7.SetActive(false);
        Travail6.SetActive(false);
        Viecommunantaire5.SetActive(false);
        Responsabilités4.SetActive(false);
        Habitation3.SetActive(false);
        Soinspersonels2.SetActive(false);
    nutrition1.SetActive(false);
}
}
